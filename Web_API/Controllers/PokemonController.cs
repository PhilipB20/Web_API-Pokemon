using Microsoft.AspNetCore.Mvc;

[Route("Pokemon")]
[ApiController]
public class PokemonController : ControllerBase
{

    [HttpGet]
    public ActionResult GimmePokemon()
    {

        Pokemon poke = new Pokemon();

        poke.name = "Snorlax";
        poke.Hp = 2000;
        poke.Type = "very sleepy";

        return Ok(poke);

    }


}



