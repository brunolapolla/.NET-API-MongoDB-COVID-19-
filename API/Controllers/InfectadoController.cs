using System;
using Api.Data.Collections;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfectadoController : ControllerBase
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<Infectado> _infectadosCollection;

        public InfectadoController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _infectadosCollection = _mongoDB.DB.GetCollection<Infectado>(typeof(Infectado).Name.ToLower());
        }

        [HttpPost]
        public ActionResult SalvarInfectado([FromBody] InfectadoDto dto)
        {
            var infectado = new Infectado(dto.Id, dto.DataNascimento, dto.Sexo, dto.Latitude, dto.Longitude);

            _infectadosCollection.InsertOne(infectado);
            
            return StatusCode(201, "Infectado adicionado com sucesso");
        }

        [HttpGet]
        public ActionResult ObterInfectados()
        {
            var infectados = _infectadosCollection.Find(Builders<Infectado>.Filter.Empty).ToList();
            
            return Ok(infectados);
        }

        [HttpGet("{_id}")]
        public ActionResult ObterInfectado(string _id)
        {
            var infectados = _infectadosCollection.Find(Builders<Infectado>.Filter.Where(_ => _.Id.Equals(_id))).ToList();
            
            return Ok(infectados);
        }

        [HttpPut("{_id}")]
        public ActionResult AtualizarInfectado([FromBody] InfectadoDto dto, string _id)
        {

            var infectado = new Infectado(dto.Id, dto.DataNascimento, dto.Sexo, dto.Latitude, dto.Longitude);

            _infectadosCollection.UpdateOne(Builders<Infectado>.Filter.Where(_ => _.Id.Equals(_id)), Builders<Infectado>
                .Update
                    .Set("dataNascimento", dto.DataNascimento)
                        .Set("sexo", dto.Sexo)
                            .Set("latitude", dto.Latitude)
                                .Set("longitude", dto.Longitude));
                
                     
            return Ok("Atualizado com sucesso.");
        }
        
        [HttpDelete("{_id}")]
        public ActionResult ExcluirInfectado(string _id)
        {

            _infectadosCollection.DeleteOne(Builders<Infectado>.Filter.Where(_ => _.Id.Equals(_id)));
            
                     
            return Ok("Excluído com sucesso.");
        }
        

    }
}
