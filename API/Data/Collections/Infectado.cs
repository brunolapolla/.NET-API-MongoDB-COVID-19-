using System;
using MongoDB.Driver.GeoJsonObjectModel;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Api.Data.Collections
{
    public class Infectado
    {
        public Infectado(string _id, DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            this.Id = _id;
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }
        
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }
}