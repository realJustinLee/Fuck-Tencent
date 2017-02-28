# coding=utf-8

# Packet sniffer in python for Linux
# Sniffs only incoming TCP packet

import socket
from struct import *
import datetime
import pcapy
import sys
from scapy.all import *
from scapy.all import send
from packet import Packet_ez

conf.promisc = 1
conf.sniff_promisc = 1


def main_start():
    conf.promisc = True
    conf.sniff_promisc = True

    def prn(packets):
        raw = packets.__str__()

        src_mac = packets[0][0].src
        dst_mac = packets[0][0].dst

        src_ip = packets[0][1].src
        dst_ip = packets[0][1].dst

        packets_ez = Packet_ez(
            destination_ip=dst_ip,
            source_ip=src_ip,
            destination_mac=dst_mac,
            source_mac=src_mac,
            packet_itself=packets,
            protocol='ip',
        )
        #  log here!
        print '==============Log here=============='

        print 'attack start!!'
        print 'This packet mac route is: ' + packets_ez.source_mac + '====>' + packets_ez.destination_mac
        print 'This packet ip route is: ' + packets_ez.source_ip + '====>' + packets_ez.destination_ip
        packets_ez.packet_judge()

        print '==============over=================='

    sniff(filter='ip', prn=prn)


if __name__ == '__main__':
    main_start()

'''
        # TCP protocol
        if protocol == 6:
            t = iph_length + eth_length
            tcp_header = packet[t:t + 20]

            # now unpack them :)
            tcph = unpack('!HHLLBBHHH', tcp_header)

            source_port = tcph[0]
            dest_port = tcph[1]
            sequence = tcph[2]
            acknowledgement = tcph[3]
            doff_reserved = tcph[4]
            tcph_length = doff_reserved >> 4

            print 'Source Port : ' + str(source_port) + ' Dest Port : ' + str(dest_port) + ' Sequence Number : ' + str(
                sequence) + ' Acknowledgement : ' + str(acknowledgement) + ' TCP header length : ' + str(tcph_length)

            h_size = eth_length + iph_length + tcph_length * 4
            data_size = len(packet) - h_size

            # get data from the packet
            data = packet[h_size:]

            print 'Data : ' + data
            return None

        # ICMP Packets
        elif protocol == 1:
            u = iph_length + eth_length
            icmph_length = 4
            icmp_header = packet[u:u + 4]

            # now unpack them :)
            icmph = unpack('!BBH', icmp_header)

            icmp_type = icmph[0]
            code = icmph[1]
            checksum = icmph[2]

            print 'Type : ' + str(icmp_type) + ' Code : ' + str(code) + ' Checksum : ' + str(checksum)

            h_size = eth_length + iph_length + icmph_length
            data_size = len(packet) - h_size

            # get data from the packet
            data = packet[h_size:]

            print 'Data : ' + data

        # UDP packets
        elif protocol == 17:
            u = iph_length + eth_length
            udph_length = 8
            udp_header = packet[u:u + 8]

            # now unpack them :)
            udph = unpack('!HHHH', udp_header)

            source_port = udph[0]
            dest_port = udph[1]
            length = udph[2]
            checksum = udph[3]

            print 'Source Port : ' + str(source_port) + ' Dest Port : ' + str(dest_port) + ' Length : ' + str(
                length) + ' Checksum : ' + str(checksum)

            h_size = eth_length + iph_length + udph_length
            data_size = len(packet) - h_size

            # get data from the packet
            data = packet[h_size:]

            print 'Data : ' + data

        # some other IP packet like IGMP
        else:
            print 'Protocol other than TCP/UDP/ICMP'
        '''
