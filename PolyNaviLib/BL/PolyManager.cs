﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PolyNaviLib.DAL;

namespace PolyNaviLib.BL
{
	public enum Weeks
	{
		Current, //Текущая неделя
		Next     //Следующая неделя
	}

	public enum Days
	{
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday,
		Sunday     //,
				   //Current, //Может понадобится
				   //Next	   //Может понадобится
	}

	public class PolyManager
	{
		Repository repository;

		public PolyManager()
		{
			repository = new Repository();
		}

		public PolyManager(string dbPath, INetworkChecker checker)
		{
			//TODO...
		}

		//Получить неделю
		public async Task<Week> GetWeekAsync(Weeks w)
		{
			Schedule schedule = await repository.GetScheduleAsync();

			return schedule.Weeks[(int)w];
		}

		//Получить день
		public async Task<Day> GetDayAsync(Weeks w, Days d)
		{
			Schedule schedule = await repository.GetScheduleAsync();

			return schedule.Weeks[(int)w].Days[(int)d];
		}


		//Получить расписание на неделю
		public async Task<List<Day>> GetScheduleByWeekAsync(Weeks w)
		{
			Schedule schedule = await repository.GetScheduleAsync();

			var week = schedule.Weeks[(int)w];

			List<Lesson> lessons = new List<Lesson>();

			//
			List<Day> days = new List<Day>();
			foreach (var d in week.Days)
			{
				//foreach (var l in d.Lessons)
				//{
				//	lessons.Add(l);
				//}
				days.Add(d);
			}

			//return lessons;
			return days;
		}

		//Получить расписание на день определенной недели
		public async Task<List<Lesson>> GetScheduleByDayAsync(Weeks w, Days d)
		{
			Schedule schedule = await repository.GetScheduleAsync();

			var day = schedule.Weeks[(int)w].Days[(int)d];

			List<Lesson> lessons = new List<Lesson>();

			foreach (var l in lessons)
			{
				lessons.Add(l);
			}

			return lessons;
		}

	}
}
