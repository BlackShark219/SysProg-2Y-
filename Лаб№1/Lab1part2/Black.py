# -*- coding: utf-8 -*-

import sys
import urllib.request
import webbrowser, os
def main():
    url = "ftp://ftp.ua.debian.org/HEADER.html"
    path = "/home/blackshark/Desktop/sysprog/lab1part2"
    urllib.request.urlretrieve(url, path + '/savedPage.txt')  # retreive page
    copy_path = path
    file=open(path + '/savedPage.txt')
    file.close()
    lighted(path + '/savedPage.txt', copy_path)

def lighted(path, copy_path):
    mod_word=sys.argv[1]
    file=open(path)
    text=file.readlines()
    new_file=open(copy_path+"/HEADER-Light.txt",'w')
    for line in text:
        if line.startswith(mod_word):
            new_file.writelines("MODIFIED"+"\n")
        else:
            new_file.writelines(line)
    new_file.close()
    file.close

main()  # entry point
