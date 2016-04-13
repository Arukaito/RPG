using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA
{
    public partial class SuperAdvent : Form
        
    {
    private Player _player;
    public SuperAdvent()
        {
            InitializeComponent();


            Location location = new Location();
        Location.ID = 1;
        Location.name = "Home";

            _player = new Player();

            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 10;
            _player.Level = 1;
            _player.ExperiencePoints = 0;


            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblLevel.Text = _player.Level.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
        }

        private void SuperAdvent_Load(object sender, EventArgs e)
        {

        }
    }
}
