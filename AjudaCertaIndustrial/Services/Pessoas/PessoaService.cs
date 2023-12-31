﻿using AjudaCertaCadastro.Services;
using AjudaCertaIndustrial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudaCertaIndustrial.Services.Pessoas
{
    public class PessoaService : Request
    {
        private readonly Request _request;
        private const string apiUrlBase = "http://fuscatcc.somee.com/ApiAjudaCerta/Pessoas";

        public PessoaService()
        {
            _request = new Request();
        }

        public async Task<Pessoa> PostRegistrarPessoaAsync(Pessoa p)
        {
            string urlComplementar = "/Registrar";
            p.Id = await _request.PostReturnIntAsync(apiUrlBase + urlComplementar, p);

            return p;
        }
    }
}
