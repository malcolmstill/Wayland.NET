#/bin/bash
mcs -t:library -out:WaylandServer.dll Display.cs EventLoop.cs Global.cs Resource.cs Client.cs
