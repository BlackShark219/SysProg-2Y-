import winreg
import binascii
key = winreg.OpenKey(winreg.HKEY_LOCAL_MACHINE, r"SOFTWARE\\", 0,winreg.KEY_READ | winreg.KEY_WOW64_64KEY)
subkey = winreg.CreateKey(key, r'SYTNYCHENKO\\')
winreg.SetValueEx(subkey,'P1', 0, winreg.REG_SZ, 'Кафедра КІ')
winreg.SetValueEx(subkey,'P2', 0, winreg.REG_BINARY,  binascii.unhexlify('2A11CEDF'))
winreg.SetValueEx(subkey,'P3', 0, winreg.REG_DWORD, 709611231) 
