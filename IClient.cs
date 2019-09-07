using System;
using System.Threading;
using System.Threading.Tasks;
using VirusTotalSDK.JSON;

namespace VirusTotalSDK
{
	public interface IClient
	{
		Task<JSON_GetToken> UserInfo();

		Task<JSON_ScanReport> Report(string ScanID, JSON_UploadSmallFile.STypeEnum Type, bool AllNfo = false);

		Task<JSON_ReScan> ReScan(string FileHash);

		Task Download(string FileHash, string FileSavePath, IProgress<ReportStatus> ReportCls = null, int TimeOut = 60, CancellationToken token = default(CancellationToken));

		Task<JSON_UploadSmallFile> Upload(object TheFile, VClient.SentType TheFileType, string FileName, IProgress<ReportStatus> ReportCls = null, CancellationToken token = default(CancellationToken));

		Task<JSON_UploadSmallFile> UploadCompressed(object TheFile, VClient.SentType TheFileType, string FileName, IProgress<ReportStatus> ReportCls = null, CancellationToken token = default(CancellationToken));

		Task<JSON_UploadSmallFile> UploadCompressedDirectory(string TheDirectory, string FileName, IProgress<ReportStatus> ReportCls = null, CancellationToken token = default(CancellationToken));

		Task<JSON_UploadSmallFile> ScanUrl(string TheUrl);
	}
}
