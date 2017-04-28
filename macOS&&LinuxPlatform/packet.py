# coding:utf-8


from scapy.all import send
from configure import lol_ip_config
from tools import *


class Packet_ez(object):
    def __init__(self, destination_ip, source_ip, destination_mac, source_mac, packet_itself, protocol):
        self.destination_ip = destination_ip
        self.source_ip = source_ip
        self.packet_itself = packet_itself
        self.protocol = protocol
        self.destination_mac = destination_mac
        self.source_mac = source_mac

    def __send_packet(self):
        send(self.packet_itself)
        print 'packet send'
        return "send_success"

    def packet_judge(self):
        if self.destination_ip in lol_ip_config:
            print 'lol packet! has been abandon...'
            pass
        elif self.source_mac == get_mac_address() or self.destination_mac == get_mac_address():
            print 'loop packet, machine-self packet, abandon'
            pass
        elif self.destination_ip == get_broadcast():
            print 'broadcast packet, abandon'
            pass
        else:
            print 'packet is clean...has judged'
            self.__send_packet()
            print 'packet has send'
        return "judge_success"
