# coding = utf-8

import os
import re
import socket
import struct
import uuid
from platform import system


def get_mac_address():
    mac = uuid.UUID(int=uuid.getnode()).hex[-12:]
    return ":".join([mac[e:e + 2] for e in range(0, 11, 2)])


def get_ip_v4():
    my_name = socket.getfqdn(socket.gethostname())
    my_addr = socket.gethostbyname(my_name)
    return my_addr


def get_gate_way():
    if system() == 'Linux':
        with open("/proc/net/route") as fh:
            for line in fh:
                fields = line.strip().split()
                if fields[1] != '00000000' or not int(fields[3], 16) & 2:
                    continue
                return socket.inet_ntoa(struct.pack("<L", int(fields[2], 16)))
    else:
        inet = get_ip_v4()
        default_gateway = ''
        for inet_element in inet.split('.')[0:3]:
            default_gateway = default_gateway + inet_element + '.'
        default_gateway += '1'
        return default_gateway


def get_broadcast():
    ifconfig_file_like = os.popen('ifconfig')
    ifconfig = ifconfig_file_like.readlines()
    broadcast = ''
    for lines in ifconfig:
        search_obj = re.search(r'inet (.*) broadcast (.*)\n', lines, re.M | re.I)
        try:
            broadcast = search_obj.group(2)
        except:
            pass
    return broadcast


print '============='

print get_ip_v4()
print get_mac_address()
print get_gate_way()
print get_broadcast()
