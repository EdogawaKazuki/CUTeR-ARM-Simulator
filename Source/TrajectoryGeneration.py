import math

l1 = 19
l2 = 19.2
l3 = 2.8
l4 = 21
def task_space_2_joint_space(x, y, z):
    y = -y
    angles = [0 for i in range(3)]
    l23 = math.sqrt(l2 * l2 + l3 * l3)
    alpha = math.atan(l3/l2)

    if x == 0:
        angles[0] = math.pi / 2
    else:
        if x > 0:
            angles[0] = math.atan(-y/x)
        else:
            angles[0] = math.pi - math.atan(y/x)

    A = -y * math.sin(angles[0]) + x * math.cos(angles[0])

    B = z - l1

    tmp = (A * A + B * B - (l23 * l23 + l4 * l4)) / (2 * l23 * l4);
    if tmp < -1:
        tmp = -0.999999
    if tmp > 1:
        tmp = 0.99999
    angles[2] = -math.acos(tmp)
    if (A * (l23 + l4 * math.cos(angles[2])) + B * l4 * math.sin(angles[2])) > 0:
        angles[1] = math.atan((B * (l23 + l4 * math.cos(angles[2])) - A * l4 * math.sin(angles[2])) /
                               (A * (l23 + l4 * math.cos(angles[2])) + B * l4 * math.sin(angles[2])))
    else:
        angles[1] = math.pi - math.atan((B * (l23 + l4 * math.cos(angles[2])) - A * l4 * math.sin(angles[2])) /
                                          -(A * (l23 + l4 * math.cos(angles[2])) + B * l4 * math.sin(angles[2])))

    angles[0] = angles[0] / math.pi * 180 - 90
    angles[1] = (angles[1] + alpha) / math.pi * 180
    angles[2] = (angles[2] - alpha) / math.pi * 180
    return angles

def joint_space_2_task_space(joints):
    Angle1Sin = math.sin(math.radians(joints[0]))
    Angle1Cos = math.cos(math.radians(joints[0]))
    Angle2Sin = math.sin(math.radians(joints[1]))
    Angle2Cos = math.cos(math.radians(joints[1]))
    Angle23Sin = math.sin(math.radians(joints[1] + joints[2]))
    Angle23Cos = math.cos(math.radians(joints[1] + joints[2]))
    x = -Angle1Sin * Angle23Cos * l4 + (
                -l2 * Angle1Sin * Angle2Cos - l3 * Angle1Sin * Angle2Sin) + 0.001
    y = Angle1Cos * Angle23Cos * l4 + (
                l2 * Angle1Cos * Angle2Cos + l3 * Angle1Cos * Angle2Sin) + 0.001
    z = Angle23Sin * l4 + (l2 * Angle2Sin - l3 * Angle2Cos) + l1
    return [x,y,z]

def move_to(init_pos, end_pos, duration):

    for t in [i / 50 for i in range(duration * 50)]:

        # ToDo
        # update coords
        x = init_pos[0] + (end_pos[0] - init_pos[0]) / duration * t
        y = init_pos[1] + (end_pos[1] - init_pos[1]) / duration * t
        z = init_pos[2] + (end_pos[2] - init_pos[2]) / duration * t

        # convert task space to joint space
        # angle0, angle1, angle2 = task_space_2_joint_space(x, y, z)

        # ToDo
        # update light,

        # push all frame to the frame list
        joint_0_list.append(str(x))
        joint_1_list.append(str(y))
        joint_2_list.append(str(z))


# Modify this function to generate trajectories
# Frequency is 50Hz (i.e. each frame costs 0.02s)
joint_0_list = []
joint_1_list = []
joint_2_list = []
def generate_trajectory():

    # prepare step
    move_to([20, 20, 20], [0, 20, 40], 1)
    move_to([0, 20, 40], [-20, 20, 20], 1)

    return [joint_0_list, joint_1_list, joint_2_list]



result = "task_space;"
trajs = generate_trajectory()
for traj in trajs:
    result += ",".join(traj)
    result += ";"

f = open("trajectory_task_space.txt", mode="w")
f.write(result)
f.close()


