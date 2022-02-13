using CayArpshay;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TranslationController : ControllerBase {
    [HttpGet(Name = "GetTranslation")]
    public Translation Get([FromQuery] string english) {
        return new Translation {
            English = english,
            PigLatin = Translator.Translate(english)
        };
    }
}
