// See https://aka.ms/new-console-template for more information

using MappingValueObjects.ConsoleApp;
using AutoMapper;

var mapperConfig = new MapperConfiguration(cfg => {
    cfg.CreateMap<string?, CEP>()
        .ConstructUsing(x => new CEP(x));
    cfg.CreateMap<CEP, string?>()
        .ConstructUsing(x => x.Value);
    cfg.CreateMap<Endereco, EnderecoVM>().ReverseMap();
});
var mapper = mapperConfig.CreateMapper();

var cepOriginal = new CEP("13205500");
var enderecoOriginal = new Endereco("Rua X", 10, cepOriginal);

var enderecoEntrada = mapper.Map<EnderecoVM>(enderecoOriginal);
var cepEntrada = enderecoEntrada.Cep;

var enderecoSaida = mapper.Map<Endereco>(enderecoEntrada);
var cepSaida = enderecoSaida.Cep;

Console.WriteLine("That's all Folks");