using Inheritance_Radio.Exceptions;

namespace Inheritance_Radio
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            List<Songs> songList = new List<Songs>();
            int N = int.Parse(Console.ReadLine());
            object[] lista = new object[N];
            int i;

           
                for (i = 0; i < N; i++)
                {
                    try
                    {
                    string[] input = Console.ReadLine().Split(';');
                    string artist = input[0];
                    string songName = input[1];
                    string songLength = input[2];
                    string[] time = songLength.Split(":");
                    int minutes = int.Parse(time[0]);
                    int seconds = int.Parse(time[1]);
                    if (minutes > 14 && seconds > 59 || minutes < 0 && seconds < 0)
                            {
                                throw new InvalidSongLengthException();
                            }
                    lista[i] = new Songs(artist, songName, minutes, seconds);
                    songList.Add((Songs)lista[i]);
                    Console.WriteLine("Song added.");
                    }
                catch (InvalidArtistNameException message)
                {
                    Console.WriteLine(message.Message);
                    continue;
                }
                catch (InvalidSongNameException message)
                {
                    Console.WriteLine(message.Message);
                    continue;
                }

                catch (InvalidSongMinutesException message)
                {
                    Console.WriteLine(message.Message);
                    continue;
                }
                catch (InvalidSongSecondsException message)

                {
                    Console.WriteLine(message.Message);
                    continue;
                }
                catch (InvalidSongLengthException message)
                {
                    Console.WriteLine(message.Message);
                    continue;

                }
            }
           
            int hours = Songs.ReturnHours();
            int mins = Songs.ReturnMins();
            int secs = Songs.ReturnSeconds();
            int counter = Songs.Count;

            Console.WriteLine($"Songs Added: {counter}");
            Console.WriteLine($"Playlist Length: {hours}h {mins}m {secs}s ");
                                  
        }
        
    }
}