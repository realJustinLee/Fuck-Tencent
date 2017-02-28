# coding = utf-8

import uuid
import socket
import sys
from platform import system
import struct
import uuid
import os
import re


def get_mac_address():
    mac = uuid.UUID(int=uuid.getnode()).hex[-12:]
    return ":".join([mac[e:e + 2] for e in range(0, 11, 2)])


def get_IPv4():
    myname = socket.getfqdn(socket.gethostname())
    myaddr = socket.gethostbyname(myname)
    return myaddr


def get_gate_way():
    if system() == 'Linux':
        with open("/proc/net/route") as fh:
            for line in fh:
                fields = line.strip().split()
                if fields[1] != '00000000' or not int(fields[3], 16) & 2:
                    continue
                return socket.inet_ntoa(struct.pack("<L", int(fields[2], 16)))
    else:
        inet = get_IPv4()
        default_gateway = ''
        for inet_element in inet.split('.')[0:3]:
            default_gateway = default_gateway + inet_element + '.'
        default_gateway += '1'
        return default_gateway


def get_broadcast():
    ifconfig_file_like = os.popen('ifconfig')
    ifconfig = ifconfig_file_like.readlines()
    net = []
    boardcast = ''
    for lines in ifconfig:
        searchObj = re.search(r'inet (.*) broadcast (.*)\n', lines, re.M | re.I)
        try:
            boardcast = searchObj.group(2)
        except:
            pass
    return boardcast


print '============='

print get_IPv4()
print get_mac_address()
print get_gate_way()
print get_broadcast()
