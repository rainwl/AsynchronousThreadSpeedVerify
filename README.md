# AsynchronousThreadSpeedVerify
Verify the speed difference between asynchronous threads and Unity main thread
## Overview
When unity only runs at 60 framerates under heavy load. Start a new thread to execute a task that needs to run at 1000hz.
## Execute
- [ ] do some reseach whether there's some way to implement this
  - [ ] Unity异步线程执行帧率和整体帧率有关吗
  - [ ] 在Unity帧数很低的时候,可以开一个线程以1000hz频率执行动作吗
  - [ ] Unity其他线程受主线程帧数影响吗
  - [ ] 
- [ ]  learn parallel async
- [ ]  implement the demo with unity