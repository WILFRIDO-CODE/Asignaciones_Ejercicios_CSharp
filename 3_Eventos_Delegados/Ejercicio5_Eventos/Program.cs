using System;
using System.Threading;

public class AlarmClock
{
    private DateTime HoraAlarma;

    public void ConfigurarAlarma(int hora, int minuto)
    {
        HoraAlarma = DateTime.Today.AddHours(hora).AddMinutes(minuto);
        Console.WriteLine($"Alarma configurada para las {HoraAlarma.ToShortTimeString()}");
    }

    public void IniciarReloj()
    {
        while (true)
        {
            if (DateTime.Now == HoraAlarma)
            {
                EnAlarmaSonando?.Invoke(this, EventArgs.Empty);
                break;

            }
            Thread.Sleep(1000);
        }
    }
    public delegate void ManejadorAlarma(object remitente, EventArgs e);

    public event ManejadorAlarma EnAlarmaSonando;
}

class program
{
    static void Main(string[] args)
    {
        AlarmClock mialarma = new AlarmClock();
       
        mialarma.EnAlarmaSonando += AlarmaActivada;
        DateTime ahora = DateTime.Now;
        mialarma.ConfigurarAlarma(ahora.Hour, ahora.Minute + 1);

        mialarma.IniciarReloj();


        static void AlarmaActivada(object remitente, EventArgs e)
        {
            Console.WriteLine("¡La alarma ha sonado!");
        }
    }
}
   

  

   