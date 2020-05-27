using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MySpotify.Upload
{
  public interface IFormFile
  {
    string ContextType { get; }

    string ContentDisposition { get; }

    IHeaderDictionary Headers { get; }

    long Lenght { get; }

    string Name { get; }

    string FileName { get; }

    Stream OpenReadStream();

    void CopyTo(Stream target);
  }
}