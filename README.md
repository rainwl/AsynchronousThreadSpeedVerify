# AsynchronousThreadSpeedVerify
Verify the speed difference between asynchronous threads and Unity main thread
## Overview
When unity only runs at 60 framerates under heavy load. Start a new thread to execute a task that needs to run at 1000hz.
- In Unity, all rendering, physics simulation, etc., takes place on the main thread
- In Unity, all Update and LateUpdate callbacks and coroutines are executed on the main thread
- A thread synchronization mechanism is needed to ensure data correctness and security
- Using thread synchronization adds some extra overhead
- Use some efficient thread synchronization mechanisms to reduce overhead, such as mutexes, read/write locks, semaphore, etc
- Improve thread performance, such as batch processing data, caching mechanisms, etc
- Use Unity's thread-safe queues such as ConcurrentQueue or BlockingCollection
- Processing data at 1000Hz can cause excessive accumulation of data generated in new threads, causing problems such as queue overflow
- Unity's rendering engine is also limited by VSync

Using thread-safe queues or other thread synchronization mechanisms, the data received from the UDP protocol is passed to the new thread for processing. After the new thread is processed, the processing result is passed back to the Unity main thread through the thread synchronization mechanism, and the data is assigned to the object transform in the scene in the Update callback function to realize data updating and rendering.



## Execute
- [x] do some reseach whether there's some way to implement this
  - [x] Is Unity Asynchronous thread execution Frame Rate related to overall frame rate:YES
  - [x] Can we open a thread to perform an action at 1000hz when the Unity frame count is low:YES
  - [x] Are other Unity threads affected by the number of frames in the main thread:NO
  - [x] So,can we do this thing?:NO
  - [x] Because,data needed to bo back in main thread
- [ ]  learn parallel async
- [ ]  implement the demo with unity