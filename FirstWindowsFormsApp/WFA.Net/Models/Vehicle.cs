using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.Net.Models
{
    public delegate void SpeedEventHandler(int vites, Color color);
    public class Vehicle
    {
        public event SpeedEventHandler SpeedEvent;
        public string Marka { get; set; }
        public string Model { get; set; }
        public bool Start { get; set; }

        private int _speed;

        public int Hiz
        {
            get => _speed;
            set
            {
                _speed = value;
                if (_speed > 1)
                {
                    switch (_speed)
                    {
                        case int s when (s < 50):
                            {
                                SpeedEvent(1, Color.FromArgb(142, 232, 14));
                                break;
                            }
                        case int s when (s < 70):
                            {
                                SpeedEvent(2, Color.FromArgb(160, 204, 10));
                                break;
                            }
                        case int s when (s < 100):
                            {
                                SpeedEvent(3, Color.FromArgb(179, 176, 8));
                                break;
                            }
                        case int s when (s < 130):
                            {
                                SpeedEvent(4, Color.FromArgb(198, 148, 6));
                                break;
                            }
                        case int s when (s < 170):
                            {
                                SpeedEvent(5, Color.FromArgb(217, 120, 4));
                                break;
                            }
                        case int s when (s < 200):
                            {
                                SpeedEvent(6, Color.FromArgb(236, 92, 2));
                                break;
                            }
                        case int s when (s < 220):
                            {
                                SpeedEvent(7, Color.FromArgb(255, 64, 0));
                                break;
                            }
                    }
                }
            }
        }
    }
}
