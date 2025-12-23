
# Frequency is 50Hz (i.e. each frame costs 0.02s)
def linear_trajectory(pos_list, time_list, frequency=50):
    '''
    this function is used to generate a linear trajectory
    pos_list: list of position (or angles)
    time_list: list of time for each position (in seconds)
    frequency: frequency of the trajectory
    '''
    result = [[] for _ in range(3)]
    for i in range(len(pos_list) - 1):
        current_pos = pos_list[i]
        next_pos = pos_list[i+1]
        current_duration = time_list[i + 1] - time_list[i]
        current_time_list = [i / frequency for i in range(current_duration * frequency)]
        for t in current_time_list:
            result[0].append(current_pos[0] + (next_pos[0] - current_pos[0]) / current_duration * t)
            result[1].append(current_pos[1] + (next_pos[1] - current_pos[1]) / current_duration * t)
            result[2].append(current_pos[2] + (next_pos[2] - current_pos[2]) / current_duration * t)
        
    return result

def cubic_trajectory(pos_list, time_list, mod_list, frequency=50):
    '''
    this function is used to generate a cubic trajectory
    pos_list: list of position (or angles)
    time_list: list of time for each position (in seconds)
    mod_list: list of mode for each position, could be 0 for "equal velocity and equal acceleration", 1 for "zero velocity", 2 for "average velocity"
    frequency: frequency of the trajectory
    '''
    pass

def linear_trajectory_with_parabolic_blends(pos_list, linear_time_list, time_list, frequency=50):
    '''
    this function is used to generate a linear trajectory with parabolic blends
    pos_list: list of position (or angles)
    linear_time_list: list of linear time for each position (in seconds)
    time_list: list of time for each position (in seconds)
    frequency: frequency of the trajectory
    '''
    pass


def trajectory_to_file(traj_list, prefix="joint"):
    '''
    this function is used to save the trajectory to a file
    traj_list: list of list, each list is a trajectory
    prefix: prefix of the file name
    '''
    result = prefix + ";"
    for traj in traj_list:
        result += ",".join([str(i) for i in traj])
        result += ";"
    f = open("trajectory_joint_space.txt", mode="w")
    f.write(result)
    f.close()

def inverse_kinematics(task_space_pos):
    '''
    this function is used to generate the joint space position from the task space position
    task_space_pos: task space position 
    '''
    pass

# example
if __name__ == "__main__":
    traj_list = linear_trajectory([[0, 0, 0], [1, 1, 1], [2, 2, 2]], [0, 1, 2])
    trajectory_to_file(traj_list, "joint")
