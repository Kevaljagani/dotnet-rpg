using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Controllers;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> {
        new Character(),
        new Character {Id= 1, Name = "sam"}
        };


        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public async Task<List<Character>> getAllCharacters()
        {
             return characters;
        }

        public async Task<Character> getCharacterById(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);
            if(character is not null) 
               return character;
            
            throw new Exception("Character not found");
        
            }
    }
}





        