# coding= utf-8
'''演进过程：
    1. 先实现即使开了arp也可以完成整个数据包的收发：'''

import os
from multiprocessing import Process

from scapy.all import *
from scapy.all import send
import binascii
from packet import Packet_ez

'''
def sniff_en():
    conf.sniff_promisc = True

    def prn(packet):
        raw = packet.__str__()
        etherheader = struct.unpack('!6s6s', raw[0:12])

        src_mac = packet[0][0].src
        dst_mac = packet[0][0].dst
        print src_mac
        print dst_mac

        src = packet[0][1].src
        dst = packet[0][1].dst

        packet_ez = Packet_ez(destination_ip=dst,
                              source_ip=src,
                              packet_itself=packet,
                              protocol='ip',
                              destination_mac=dst_mac,
                              source_mac=src_mac,
                              )

        print '============look here==========================='

        print binascii.hexlify(raw)
        print dst
        print src

        packet_ez.packet_judge()
        print src + ' ====> ' + dst

        if src_mac != 'a0:99:9b:0f:aa:45' and dst_mac != 'a0:99:9b:0f:aa:45':
            print 'lp5!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!'
        print '=============over over over====================='
        # init the packet

    sniff(filter='ip', prn=prn)


def child_process(name):
    print "i am a child process and pid is: " + str(os.getpid())

if __name__ == '__main__':
    print 'Parents process: '+str(os.getpid()) + ' now start'
    child_p = Process(target=child_process, args=('hahaha', ))
    child_p.start()
    child_p.join()
    print "child_p process is over"

'''

from multiprocessing import Process
import os


# 子进程要执行的代码
def run_proc(name):
    while(1):
        print 1
    print 'Run child process %s (%s)...' % (name, os.getpid())


if __name__ == '__main__':
    print 'Parent process %s.' % os.getpid()
    p = Process(target=run_proc, args=('test',))
    print 'Process will start.'
    p.start()
    p.join()
    print 'Process end.'

