# coding=utf-8

import threading


def start_threading(func, *args):
    ret = threading.Thread(target=func, args=args)
    ret.start()
