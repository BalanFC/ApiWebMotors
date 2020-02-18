using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
	public interface IAnuncioWebMotorsService
	{
		IEnumerable<AnuncioWebMotors> GetAll();
		bool Create(AnuncioWebMotors model);
		bool Update(AnuncioWebMotors model);
		bool Delete(int id);
		AnuncioWebMotors Get(int id);
	}
}
