import math
from typing import List
import numpy as np
import matplotlib.pyplot as plt
import trimesh

def angles_from_simulation_to_model(joint_angles: List[float]) -> List[float]:
    # Placeholder for the actual conversion logic
    return joint_angles

def forward_kinematics_open_manipulator_pro_3dof(joint_angles: List[float], l3_long: float = 38.11) -> List[float]:
    """
    This method calculates the forward kinematics for a 3DOF robotic arm based on the following formulas:
    xp = sin(θ1) * (l2 * cos(θ2) + l3 * cos(φ2 + φ3))
    yp = cos(θ1) * (l2 * cos(θ2) + l3 * cos(φ2 + φ3))
    zp = l1 + l2 * sin(θ2) + l3 * sin(φ2 + φ3)
    where l1 = 15.9, l2 = sqrt(26.4^2 + 3.0^2), l3 = 38.11, φ2 = θ2 + atan(0.3/26.4)
    """
    # joint_angles = angles_from_simulation_to_model(joint_angles)
    l1 = 15.9
    l2 = math.sqrt(26.4**2 + 3.0**2)
    l3 = math.sqrt(l3_long**2 + 3.0**2)

    theta1 = joint_angles[:, 0]
    phi2 = joint_angles[:, 1] - math.atan2(3.0, 26.4)  # Adjusting for the offset
    phi3 = joint_angles[:, 2] + math.atan2(3.0, 26.4) + math.atan2(3.0, l3_long)  # Adjusting for the offset

    xp = np.sin(-theta1) * (l2 * np.cos(phi2) + l3 * np.cos(phi2 + phi3))
    yp = np.cos(-theta1) * (l2 * np.cos(phi2) + l3 * np.cos(phi2 + phi3))
    zp = l1 + l2 * np.sin(phi2) + l3 * np.sin(phi2 + phi3)

    return np.stack([xp, yp, zp], axis=1)

def compute_batch_forward_kinematics(joint_angles_batch: List[List[float]]) -> List[List[float]]:
    return [forward_kinematics_open_manipulator_pro_3dof(joint_angles) for joint_angles in joint_angles_batch]

def compute_single_layer_workspace(resolution=100):
    # theta1 = np.array([0])
    theta1 = np.linspace(-np.pi/2, np.pi/2, resolution)
    theta2 = np.linspace(0, np.pi, resolution)
    theta3 = np.linspace(-np.pi*3/4, 0, resolution)

    # theta_batch = np.stack(np.meshgrid(theta1, theta2, theta3), axis=3).reshape(-1, 3)
    theta_batch1 = np.stack(np.meshgrid(theta1, theta2, np.array([0])), axis=3).reshape(-1, 3)
    theta_batch2 = np.stack(np.meshgrid(theta1, np.array([0]), theta3), axis=3).reshape(-1, 3)
    theta_batch3 = np.stack(np.meshgrid(theta1, theta2, np.array([-np.pi*3/4])), axis=3).reshape(-1, 3)
    theta_batch4 = np.stack(np.meshgrid(theta1, np.array([np.pi]), theta3), axis=3).reshape(-1, 3)  
    theta_batch5 = np.stack(np.meshgrid(np.array([np.pi/2]), theta2, theta3), axis=3).reshape(-1, 3)
    theta_batach6 = np.stack(np.meshgrid(np.array([-np.pi/2]), theta2, theta3), axis=3).reshape(-1, 3)

    theta_batch = np.concatenate([theta_batch1, theta_batch2, theta_batch3, theta_batch4, theta_batch5, theta_batach6], axis=0)
    # theta_batch = np.stack(np.meshgrid(theta1, theta2, np.array([-np.pi])), axis=3).reshape(-1, 3)
    positions = forward_kinematics_open_manipulator_pro_3dof(theta_batch)

    triangles = []
    batch_size = resolution
    for i in range(4):
        for j in range(batch_size-1):
            cur_pt = np.arange(batch_size-1)
            right_pt = cur_pt + batch_size
            below_pt = cur_pt + 1 
            below_right_pt = below_pt + batch_size
            triangles.append(np.stack([right_pt, cur_pt, below_pt], axis=1) + i * batch_size**2 + j * batch_size)
            triangles.append(np.stack([below_right_pt, below_pt, right_pt], axis=1) + i * batch_size**2 + j * batch_size)
    
    triangles2 = []
    for i in range(4, 6):
        for j in range(batch_size-1):
            cur_pt = np.arange(batch_size-1) * batch_size
            right_pt = cur_pt + 1
            below_pt = cur_pt + batch_size 
            below_right_pt = below_pt + 1
            triangles.append(np.stack([right_pt, cur_pt, below_pt], axis=1) + i * batch_size**2 + j * 1)
            triangles.append(np.stack([below_right_pt, below_pt, right_pt], axis=1) + i * batch_size**2 + j * 1)
            triangles2.append(np.stack([right_pt, cur_pt, below_pt], axis=1) + 0 * i * batch_size**2 + j * 1)
            triangles2.append(np.stack([below_right_pt, below_pt, right_pt], axis=1) + 0 * i * batch_size**2 + j * 1)
    triangles = np.concatenate(triangles, axis=0)
    triangles2 = np.concatenate(triangles2, axis=0)

    print(triangles.shape, np.max(triangles), np.min(triangles))
    # pos2 = forward_kinematics_open_manipulator_pro_3dof(theta_batch2)
    # pos3 = forward_kinematics_open_manipulator_pro_3dof(theta_batch3)
    # idx1 = np.where(pos2[:, 1] > 3 )
    # pos2 = pos2[idx1]
    # print(idx1)
    # idx2 = np.where(pos3[:, 1] > 3 )
    # pos3 = pos3[idx2]
    # idx1 = np.argmin(pos2[:, 1])
    # idx2 = np.argmin(pos3[:, 1])
    # line_start = pos2[idx1]
    # line_start[1] = 3
    # line_end = pos3[idx2]
    # line_end[1] = 3
    # pos5 = np.linspace(line_start, line_end, resolution)
    # positions = np.concatenate([positions, pos2, pos3, pos5], axis=0)
    print(forward_kinematics_open_manipulator_pro_3dof(np.array([[0, np.pi, -np.pi]])))

    # mask1 = np.abs(positions[:, 0]) < 3
    # mask2 = np.abs(positions[:, 1]) < 3
    # mask3 = (positions[:, 2] >= 0) & (positions[:, 2] <= 15.9)  
    # base_mask = np.repeat((mask1 & mask2 & mask3).reshape(-1, 1), 3, axis=1)
    # base_mask = np.repeat((positions[:, 1] <= 0).reshape(-1, 1), 3, axis=1)

    # print(base_mask.shape, positions.shape)
    # positions = positions[~base_mask.astype(bool)].reshape(-1, 3)
    # print(positions.shape)
    plt.scatter(positions.reshape(-1, 3)[:, 1], positions.reshape(-1, 3)[:, 2], s=1)
    plt.show()

    pcd = trimesh.points.PointCloud(positions)
    mesh = trimesh.Trimesh(positions, triangles)
    partial_pcd = trimesh.points.PointCloud(positions[40000:])
    partial_mesh = trimesh.Trimesh(positions[40000:], triangles2)
    pcd.export("workspace.ply")
    mesh.export("workspace.obj")
    partial_pcd.export("partial_plane.ply")
    partial_mesh.export("partial_plane.obj")
    

if __name__ == "__main__":
    compute_single_layer_workspace()