using System;
using System.IO;

 static String GetTimestamp(DateTime value)
{
    return value.ToString("yyyyMMddHHmmssffff");
}
//  ...later on in the code
String timeStamp = GetTimestamp(DateTime.Now);
