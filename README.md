# RTPCheck
A small utility to check if Windows 10/11 Real-Time Protection has been disabled. In theory, this should also default to the correct disabled state on windows that do not have RTP available.

*Note: This is read-only, so no priv escalation should be required.*

## Using the RTP class
You can use this RTP class in whatever you like. Just call the static method and you're golden.
```csharp
using RealTimeProtection;

Console.WriteLine("Protection: " + (RTP.Disabled() ? "OFF" : "ON"));```
