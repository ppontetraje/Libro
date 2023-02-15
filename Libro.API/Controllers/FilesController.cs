using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace Libro.API.Controllers
{
    
    [ApiController]
    [Route("api/files")]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _extensionContentTypeProvider;
        public FilesController(FileExtensionContentTypeProvider extensionContentTypeProvider)
        {
            _extensionContentTypeProvider = extensionContentTypeProvider
                ?? throw new System.ArgumentNullException(nameof(extensionContentTypeProvider));
        }

        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId)
        {
            var pathToFile = "solicitud_de_servicio.pdf";
            if (!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }
            if (!_extensionContentTypeProvider.TryGetContentType(pathToFile, out var contentType))
            {
                contentType = "application/octect-stream";
            }
            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            return File(bytes, contentType, Path.GetFileName(pathToFile));
        }
        
    }
}
