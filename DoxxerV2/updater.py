import ctypes  # An included library with Python install.
from urllib.request import urlopen

def Updater():
    #thisVersion = getversion();
    num = ctypes.windll.user32.MessageBoxW(0, "Would you like to check for updates?", "Update Checker", 4)
    if num == 6:
        ctypes.windll.user32.MessageBoxW(0, "Program is now checking for updates. Please be patient.", "Check for updates?", 0)
        #versionNum = urlopen('http://drizzybot.com/releases/version.txt').read().decode('utf-8') ##SITE/releases/version.txt
        versionNum = "2.0.0.2"
        if versionNum == "2.0.0.2": #find way to find program version
            ctypes.windll.user32.MessageBoxW(0, "No update is available at this time. Program will continue.", "Update Checker", 0)
            return
        ctypes.windll.user32.MessageBoxW(0, "An update is available. The new version will now be downloaded...", "Update Checker", 0)
        with urllib.request.urlopen('http://www.google.com') as response, open("Dox Tool - Updated.exe", 'wb') as out_file: ##SITE/releases/Dox%20Tool.exe
            data = response.read() # a `bytes` object
            out_file.write(data)
        ctypes.windll.user32.MessageBoxW(0, "Done! Launching new version...", "Update Checker", 0)
        subprocess.run("Dox Tool - Updated.exe")
        quit()
