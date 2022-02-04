﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static VideoRentalStore.CPrice;

namespace VideoRentalStore
{
	public enum FilmType
	{
		[Display(Name = "New Release")]
		NewRelease,
		[Display(Name = "Regular Film")]
		RegularFilm,
		[Display(Name = "Old Film")]
		OldFilm
	}
	public abstract class CFilm
	{


		protected int filmBonusPoint = 1;

		PriceType priceType = PriceType.BASIC_PRICE;
		public FilmType filmType = FilmType.RegularFilm;

		[DisplayName("FilmType")]
		public FilmType FilmTypeText { get { return filmType; } }
		public string Title { get; set; }
		public int Copies { get; set; }
		public bool Available
		{
			get { return Copies > 0; }
		}

		public CFilm()
		{
		}

		public CFilm(FilmType fType, string title, int fBonusPoint)
		{
			filmType = fType;
			filmBonusPoint = fBonusPoint;
			this.Title = title;
		}

		public CFilm(FilmType fType)
		{
			filmType = fType;
			priceType = PriceType.BASIC_PRICE;
			switch (filmType)
			{
				case FilmType.NewRelease:
					priceType = PriceType.BASIC_PRICE;
					break;
			}

		}

		public CFilm(FilmType fType, int fBonusPoint) {
			filmType = fType;
			filmBonusPoint = fBonusPoint;
		}
		public CFilm(string title)
		{
			this.Title = title;
		}


		public void AddCopy()
		{
			Copies++;
		}

		void RemoveCopy()
		{
			Copies--;
		}

		int FilmBonusPoint {
			get {
				int iBpoint = 1;
				switch (filmType)
				{
					case FilmType.NewRelease:
						iBpoint = 2;
						break;

				}
				return iBpoint; }
		}
		public abstract int GetRentDays();
		public virtual int GetBonusPointDay() 
		{
			return 5;
		}
		public abstract decimal CalculateRentalPrice( int totalDays);
		public int CalculateBonusPoints(int totalDays)
		{
			return totalDays * GetBonusPointDay();
		}
		

		public int GetExtraDays(int totalDays)
		{
			int extraDays = GetRentDays() - totalDays;
			return (extraDays > 0 ? extraDays : 0) ;
		}
		//public decimal CalculateRentalPrice(bool useBunusPoints,int days)
		//{
		//		decimal dPrice = 3;
		//		switch (priceType)
		//		{
		//			case PriceType.PREMIUM_PRICE:
		//				dPrice = 4;
		//				break;

		//		}


		//		return dPrice;
		//}
		public int getFilmBonusPonts()
		{
			return filmBonusPoint ;
		}
		public FilmType getFilmType()
		{
			return filmType;
		}
		public void setFilmType(FilmType ftype)
		{
			filmType= ftype;
		}
		public PriceType getPriceType()
		{
			return priceType;
		}
		
	}
}
