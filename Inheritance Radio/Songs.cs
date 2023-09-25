using Inheritance_Radio.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Radio
{
    public class Songs
    {
        protected string artist;
        protected string song;
        protected int minutes;
        protected int seconds;

        public static int sumMins = 0;
        public static int sumSec = 0;
        public static int Count = 0;

     

        public static int ReturnHours()
        {
            int hours = sumMins / 60;
            return hours;
        }

        public static int ReturnMins()

        {
            int mins1;
            int mins2;
            if (sumMins > 60)
            {
                mins1 = sumMins % 60; 

            }         
            else mins1 = sumMins;

            if (sumSec > 60)
            {
                mins2 = sumSec / 60;
            }
            else mins2 = 0;

            int mins = mins1 + mins2;
            return mins;

        }

        public static int ReturnSeconds()
        {
            int seconds;
            if (sumSec > 60)
            {
                seconds = sumSec % 60;
            }
            else seconds = sumSec;

            return seconds;
        }
       

        public string Artist
        {
            get
            {
                return this.artist;
            }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols.");
                }
                this.artist = value;
            }
        }
        public string Song
        {
            get
            {
                return this.song;
            }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException("Song name should be between 3 and 30 symbols."
);
                }
                else
                this.song = value;
            }
        }

        public int Minutes
        {
            get
            {
                return this.minutes;
            }
            set
            {
                if (value < 0 || value > 14) 
                { 
                throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
                }
                else
                this.minutes = value;
            }
        }

        public int Seconds
        {
            get
            {
                return this.seconds;
            }
            set
            {
                if (value < 0 || value > 59) 
                {
                    throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
                }
                else
                
                this.seconds = value;
            }
        }




        public Songs(string artist, string song, int minutes, int seconds) 
        
        {
            Artist = artist;
            Song = song;
            Minutes = minutes;
            Seconds = seconds;
            sumMins += minutes;
            sumSec += seconds;
            Count++;
        }  


    }
}
