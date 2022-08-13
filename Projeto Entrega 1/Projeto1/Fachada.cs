using Projeto1.Cadastros;
using Projeto1.Controladores;
using Projeto1.Entidades;
using Projeto1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Fachada
    {
        private readonly ControlLogin _controlLogin;
        private readonly ControlListarPontos _controlListarPontos;
        private readonly ControlListagem _controlListagem;
        private readonly ControlTelaAgendamento _controlTelaAgendamento;
        private readonly ControlRegistro _controlRegistro;

        public Fachada(IContaRepositorio contaRepositorio, IPontoRepositorio pontoRepositorio, IAgendamentoRepositorio agendamentoRepositorio)
        {
            var cadastroConta = new CadastroConta(contaRepositorio);
            var cadastroPonto = new CadastroPonto(pontoRepositorio);
            var cadastroAgendamento = new CadastroAgendamento(agendamentoRepositorio);
            _controlLogin = new ControlLogin(cadastroConta);
            _controlListarPontos = new ControlListarPontos(cadastroPonto);
            _controlListagem = new ControlListagem(cadastroAgendamento);
            _controlTelaAgendamento = new ControlTelaAgendamento(cadastroAgendamento,cadastroConta, cadastroPonto);
            _controlRegistro = new ControlRegistro(cadastroConta, cadastroAgendamento);
        }

        public int VerificarLogin(string cpf, string senha)
        {
            return _controlLogin.Verificar(cpf, senha);
        }

        public ICollection<PontoDeVacinacao> GetPontos()
        {
            return _controlListarPontos.GetPontos();
        }
        public ICollection<Agendamento> ListarAgendamentos(int pontoId, DateTime horario)
        {
            return _controlListagem.ConsultarAgendamentos(pontoId, horario);
        }

        public bool Agendar(int contaId, int pontoId, int vacinaId, DateTime horario )
        {
            return _controlTelaAgendamento.RealizarAgendamento(contaId, pontoId, vacinaId, horario);
        }

        public void RegistrarVacinacao(int agendamentoId, int profissionalId)
        {
            _controlRegistro.RegistrarVacinacao(agendamentoId, profissionalId);
        }
    }
}
