using dto = Dtos;
using ent = Entities;

namespace Util
{
    public static class Mapper
    {
        public static dto.Movie MapMovieEntityToDto(ent.Movie movieEntity)
        {
            return new();
        }
    }
}