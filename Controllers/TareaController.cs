﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace probando.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TareaController : ControllerBase
	{

		//private static tarea[] Tareas = new[]
		//{
		//	"Abrir", "Cerrar", "Poner", "Quitar", "Borrar", "Probar"
		//};
		// private List<Tarea> tareaList = new List<Tarea>();
		public List<Tarea> tareaList = Program.tareaList;

		public TareaController()
		{
			if ( tareaList.Count == 0)
			{

			tareaList.Add(new Tarea(0, "Crear proyecto", new DateTime(2021, 1, 1), DateTime.MinValue, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", true, "Pepito"));
			tareaList.Add(new Tarea(1, "Programar proyecto", new DateTime(2021, 1, 10), DateTime.MinValue, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", true, "Pepito"));
			tareaList.Add(new Tarea(2, "Probar proyecto", new DateTime(2021, 1, 21), DateTime.MinValue, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", true, "Pepito"));
			tareaList.Add(new Tarea(3, "Resolver fallos", new DateTime(2021, 2, 7), DateTime.MinValue, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", false, "Pepito"));
			tareaList.Add(new Tarea(4, "Resolver fallos", new DateTime(2021, 2, 7), DateTime.MinValue, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", false, "Pepito"));
			tareaList.Add(new Tarea(5, "Subir a producción", new DateTime(2021, 2, 9), DateTime.MinValue, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", false, "Pepito"));
			}
		}

		// GET: api/<TareaController>
		[HttpGet]
		public IEnumerable<Tarea> Get()
		{

			return tareaList.ToArray();

		}

		// GET api/<TareaController>/5
		[HttpGet("{id}")]
		public Tarea Get(int id)
		{
			Tarea tarea = tareaList.Find(item => item.Id == id);
			return tarea;
		}

		// POST api/<TareaController>
		[HttpPost]
		public IEnumerable<Tarea> Post([FromBody] Tarea tarea)
		{
			var lastTarea = tareaList.Last();
			var nextTareaId = lastTarea.Id + 1;

			tareaList.Add(new Tarea(nextTareaId, tarea.NombreTarea, tarea.FechaCreacion, DateTime.MinValue, tarea.Explicacion, tarea.Importante, tarea.Creador));

			return tareaList;


		}

		// PUT api/<TareaController>/5
		[HttpPut("{id}")]
		public Tarea Put(int id, [FromBody] Tarea tarea)
		{
			Tarea tareaFind = tareaList.Where(p => p.Id == id).FirstOrDefault();

			if( tareaFind != null)
			{
				tareaFind.NombreTarea = tarea.NombreTarea;
				tareaFind.FechaFinalicacion = tarea.FechaFinalicacion;
				tareaFind.Importante = tarea.Importante;
			}
			return tareaFind;
		}

		// DELETE api/<TareaController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			
		}
	}
}
