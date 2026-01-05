import threading
import struct
import socket
import time
import math

def float_to_bytes(float_num, byte_order='<'):
    float_size = 4
    byte_array = struct.pack(byte_order + 'f', float_num)
    return byte_array

def int_to_bytes(interger, byte_order='little', signed=True):
    byte_size = 2
    byte_array = interger.to_bytes(byte_size, byte_order, signed=signed)
    return byte_array

def send_udp_data(data, path_time, ip='192.168.0.103', port=1234):
    sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    start_time = time.time()
    previous_time = start_time
    for i, info in enumerate(data):
        sock.sendto(info, (ip, port))
        current_time = time.time()
        elapsed_time = current_time - previous_time
        previous_time = current_time
        actual_freq = 1 / elapsed_time if elapsed_time > 0 else float('inf')
        print(f'Packet {i+1}: Elapsed Time = {elapsed_time:.6f}s, Actual Frequency = {actual_freq:.2f}Hz')
        supposed_time = start_time + path_time * i
        if time.time() < supposed_time:
            time.sleep(supposed_time - time.time())
    end_time = time.time()
    print('Total Time:', end_time - start_time)
    sock.close()

def pack_data(jointList, path_time):
    DOF = len(jointList)
    buffer = bytearray(1 + 4 + 4 * DOF)
    buffer[0] = 2
    for i in range(DOF):
        buffer[1 + 4 * i:1 + 4 * (i+1)] = float_to_bytes(jointList[i])
    buffer[1 + 4 * DOF:1 + 4 * (DOF+1)] = float_to_bytes(path_time)
    return buffer

def GenTraj(t, freq):
    num_frames = (int) (t * freq)
    jointList = []
    for i in range(num_frames*1):
        tmpList = [60 * math.sin(math.pi * 2 * i / (num_frames-1)), 0, 0, 0, 0, 0]
        jointList.append(pack_data(tmpList, 1 / freq))
    return jointList

# Example usage
if __name__ == "__main__":
    freq = 50
    traj_time = 5.
    data = GenTraj(traj_time, freq)
    send_udp_data(data, 1/freq)