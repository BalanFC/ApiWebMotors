using Entities;
using InfraScructure;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services
{
	public class AnuncioWebMotorsService : IAnuncioWebMotorsService
	{
		private readonly WebMotorsDbContext _webMotorsDbContext;

		public AnuncioWebMotorsService(WebMotorsDbContext webMotorsDbContext)
		{
			_webMotorsDbContext = webMotorsDbContext;
		}

		public IEnumerable<AnuncioWebMotors> GetAll()
		{
			List<AnuncioWebMotors> anuncioWebMotorsList;

			try
			{
				anuncioWebMotorsList = _webMotorsDbContext.AnuncioWebMotors.ToList();
			}
			catch (System.Exception)
			{

				return null;
			}

			return anuncioWebMotorsList;
		}

		public bool Create(AnuncioWebMotors model)
		{
			try
			{
				_webMotorsDbContext.Add(model);
				_webMotorsDbContext.SaveChanges();
			}
			catch (System.Exception e)
			{
				var error = e.Message;
			}

			return true;
		}

		public bool Update(AnuncioWebMotors model)
		{
			try
			{
				var anuncioWebMotors = _webMotorsDbContext.AnuncioWebMotors.Single(x => x.Id == model.Id);
				anuncioWebMotors.Marca = model.Marca;
				anuncioWebMotors.Modelo = model.Modelo;
				anuncioWebMotors.Versao = model.Versao;
				anuncioWebMotors.Ano = model.Ano;
				anuncioWebMotors.Quilometragem = model.Quilometragem;
				anuncioWebMotors.Observacao = model.Observacao;

				_webMotorsDbContext.Update(anuncioWebMotors);
				_webMotorsDbContext.SaveChanges();
			}
			catch (System.Exception)
			{

				return false;
			}

			return true;
		}

		public bool Delete(int id)
		{
			try
			{
				_webMotorsDbContext.Entry(new AnuncioWebMotors { Id = id }).State = EntityState.Deleted;
				_webMotorsDbContext.SaveChanges();
			}
			catch (System.Exception)
			{

				return false;
			}

			return true;
		}

		public AnuncioWebMotors Get(int id)
		{
			var result = new AnuncioWebMotors();
			try
			{
				result = _webMotorsDbContext.AnuncioWebMotors.Single(x => x.Id == id);
			}
			catch (System.Exception)
			{
				return null;
			}

			return result;
		}
	}
}

