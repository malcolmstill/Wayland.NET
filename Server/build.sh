#/bin/bash
rm WaylandServerProtocol.*
mono ../Scanner/Scanner.exe /usr/share/wayland/wayland.xml >> WaylandServerProtocol.cs
rm ZxdgShellUnstableV6ServerProtocol.*
mono ../Scanner/Scanner.exe /usr/share/wayland-protocols/unstable/xdg-shell/xdg-shell-unstable-v6.xml >> ZxdgShellUnstableV6ServerProtocol.cs
mcs -debug+ -t:library -out:WaylandServer.dll Display.cs SHMBuffer.cs EventLoop.cs Global.cs Resource.cs Client.cs Utils.cs Region.cs WaylandServerProtocol.cs
# mcs -t:library -r:WaylandServer.dll -out:WaylandServerProtocol.dll WaylandServerProtocol.cs
mcs -debug+ -t:library -r:WaylandServer.dll -out:ZxdgShellUnstableV6ServerProtocol.dll ZxdgShellUnstableV6ServerProtocol.cs
