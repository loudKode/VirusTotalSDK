# VirusTotalSDK
.NET API Library for virustotal.com


`Download:`[https://github.com/loudKode/VirusTotalSDK/releases](https://github.com/loudKode/VirusTotalSDK/releases)<br>
`NuGet:`
[![NuGet](https://img.shields.io/nuget/v/DeQmaTech.VirusTotalSDK.svg?style=flat-square&logo=nuget)](https://www.nuget.org/packages/DeQmaTech.VirusTotalSDK)<br>

# Functions:
* UserInfo
* Report
* ReScan
* Download
* Upload
* UploadCompressed
* UploadCompressedDirectory
* ScanUrl

# Example:
**get token**
```vb
Dim tkn = Await VirusTotalSDK.GetToken.GetToken("user", "pass")
```

**set client**
```vb
Dim cLENT As VirusTotalSDK.IClient = New VirusTotalSDK.VClient("token", Nothing, Nothing)
```

**upload small or large file(> 32 mb)**
```vb
Dim RSLT = Await cLENT.Upload("C:\VB.exe", VirusTotalSDK.VClient.SentType.file, "VB.exe", nothing, nothing)
```
