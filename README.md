# PerfCostTest

Reading System Information (CPU usage) using Performance Counters and the Win32 API: what's the difference in terms of "CPU cost"?

![image](https://user-images.githubusercontent.com/7286466/183282345-6cf92344-a142-4368-b6f1-cb7cd7c23b34.png)

Using "Performance Conters" can cost up to 10x in some cases, thus when writing code that reads and stores the application performance we should always check how much it costs!
