# Aresskit v2.0
## Next Generation Remote Administration Tool (RAT)

**Read the** [**Aresskit WiKi**](https://github.com/BlackVikingPro/aresskit/wiki)

**Watch the** [**Aresskit Video Tutorial**](https://www.youtube.com/watch?v=7hADAbQPU4M)

***

### What is Ares?
**Ares - Arsenal of Reaping Exploitational Suffering (for lack of a better name)**
Ares is my first large-scale framework consiting of special, hand-crafted malware
for the Windows OS. This framework was designed to work with Windows 7 and up,
however it has only been tested on Windows 10. 


**Aresskit** is designed to infest a target machine, and under special command and control
it has the ability to programmatically assume control over the victim. In which it can
execute administrative tasks that vary in complexity and strength. 

### Some quick features of Aresskit:
* Aresskit comes equipped with networking tools and administration tools such as:
* Built-In Port Scanner
* Reverse Command Prompt / Powershell Shells
* UDP/TCP Port Listener (similar to Netcat)
* File uploading/downloading (coming soon)
* Live Cam/Mic Feed (coming soon)
* Screenshot(s) (using [AnonymousFiles](https://anonymousfiles.io/))
* Real-Time and Log-based Keylogger
* Self-destruct feature (protect your privacy)

***

### Build Requirements:
Some of these may not be required, but they do help in development
 * [Visual Studio 2019](https://www.visualstudio.com/downloads/)
 * [.NET Framework 4](https://www.microsoft.com/en-us/download/details.aspx?id=17851)
 * [Costura.Fody](https://github.com/Fody/Costura)
	* `PM> Install-Package Costura.Fody`
 * [Json.NET](https://www.newtonsoft.com/json)
	* `PM> Install-Package Newtonsoft.Json`

### How Aresskit works:
The software has a simple concept, yet a complicated design. The idea of Aresskit is
to be deployed and executed on a target machine, then to send a specially constructed
command line interface back to the attacker's listening server. Then, the attacker
will be able to pipe commands back to the infected machine, in which the specified
commands are programmed into the source code for ease of access/use. This is a simple
backdoor; however, the unique thing about Aresskit is that commands are implemented
simply by adding Classes/Methods to the source code. Read more in the [Aresskit Wiki](https://github.com/BlackVikingPro/aresskit/wiki)

### How to build/deploy Aresskit
1. Modify variables found at the top of `Program.cs` to suite your needs
2. To build the software, simply execute `build-release.bat` and publish the exe.

### How to use Aresskit
In order to use Aresskit, you will need a VPS or at least some other port listener.
For my testing purposes, I used Netcat (native on Linux as command `nc`). You can use
pretty much anything you would like to though. 
1. The fist thing you'll need to do is to open a port and listen for connections on it
 using netcat. This command should help: `$ nc -lvk 9000`. Make sure no firewalls are
 blocking connections on whatever port you choose.
2. The program, assuming it has already been deployed, now needs to be executed either
 by you, the attacker, or the victim (try Social Engineering).
3. Then, once the program is executed on the victim's end, you should now see some
 text being piped back to you on your listening port. The text should simply display
 `aresskit> .`. Which now you can start piping your commands and controlling the victim!

### How to control Aresskit after it has been deployed/executed:
So now that you've deployed and executed the malware onto your target, you need to learn
the basics of how the program works. Much like Meterpreter, it is able to recieve and parse
custom commands to be executed by the malare. 

The way the command and control system works is that whenever it received input, the
syntax is required to match up to Class/Method names built into the software. For example,
you would pipe in the command `aresskit> Administration::IsAdmin`, and the
malware should return **True** or **False**, based on whether or not the executable has
administrative permissions. Notice that **Administration** is the name of the class that is built
into the software (take a look at `Administration.cs`). For every class/method there is built
into the malware, it then becomes a new command in the interpreter. 

This design system was created to create an extremely easy, and effective method of allowing
other engineers to include custom commands into the malware to give it more power and user
customizability. 

***

### Disclaimer:
This project was created to for educational purposes to demonstrate the capabilities of RAT
infections on protected machines. Please do not use this in any malicious acts for any reason,
as I am not responsible for any of your actions. 

### Help/Support:
If you'd like to help out with any code, just [fork](https://github.com/BlackVikingPro/aresskit/fork) the repo, make your changes
and submit a [pull request](httphttps://github.com/BlackVikingPro/aresskit/pulls)! All advancments are much appreciated, and
feel free to add your @ to the list of contributors!

### Contributors:
 * [BlackVikingPro](https://github.com/BlackVikingPro)
