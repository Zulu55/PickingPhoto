using System.IO;
using System.Threading.Tasks;

namespace PickingPhoto
{
    public interface IPicturePicker
    {
        Task<Stream> GetImageStreamAsync();
    }
}