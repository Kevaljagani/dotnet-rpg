using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> getAllCharacters(); 

        Task<Character> getCharacterById(int id);

        Task<List<Character>> AddCharacter(Character newCharacter);

    }
}