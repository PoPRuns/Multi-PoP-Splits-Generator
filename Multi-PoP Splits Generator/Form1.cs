using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Multi_PoP_Splits_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.listBox1.AllowDrop = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                comboBox1.Invoke((MethodInvoker)delegate
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        label2.Invoke((MethodInvoker)delegate
                        {
                            label2.ForeColor = SystemColors.ControlDark;
                        });
                        comboBox2.Invoke((MethodInvoker)delegate
                        {
                            comboBox2.Enabled = false;
                        });
                        label3.Invoke((MethodInvoker)delegate
                        {
                            label3.ForeColor = SystemColors.ControlDark;
                        });
                        comboBox3.Invoke((MethodInvoker)delegate
                        {
                            comboBox3.Enabled = false;
                        });
                        button1.Invoke((MethodInvoker)delegate
                        {
                            button1.Enabled = true;
                        });
                        label4.Invoke((MethodInvoker)delegate
                        {
                            label4.ForeColor = SystemColors.ControlText;
                        });
                        listBox1.Invoke((MethodInvoker)delegate
                        {
                            listBox1.Enabled = true;
                            if (listBox1.Items.Count != 8)
                            {
                                listBox1.Items.Clear();
                                listBox1.Items.Add("Prince of Persia (1989)");
                                listBox1.Items.Add("Prince of Persia 2: The Shadow and the Flame");
                                listBox1.Items.Add("Prince of Persia 3D");
                                listBox1.Items.Add("Prince of Persia: The Sands of Time");
                                listBox1.Items.Add("Prince of Persia: Warrior Within");
                                listBox1.Items.Add("Prince of Persia: The Two Thrones");
                                listBox1.Items.Add("Prince of Persia (2008)");
                                listBox1.Items.Add("Prince of Persia: The Forgotten Sands");
                            }
                        });
                    }

                    else if (comboBox1.SelectedIndex == 1)
                    {
                        label2.Invoke((MethodInvoker)delegate
                        {
                            label2.ForeColor = SystemColors.ControlText;
                        });
                        comboBox2.Invoke((MethodInvoker)delegate
                        {
                            comboBox2.Enabled = true;
                            switch (comboBox2.SelectedIndex)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    label3.Invoke((MethodInvoker)delegate
                                    {
                                        label3.ForeColor = SystemColors.ControlText;
                                    });
                                    comboBox3.Invoke((MethodInvoker)delegate
                                    {
                                        comboBox3.Enabled = true;
                                        switch (comboBox3.SelectedIndex)
                                        {
                                            case 0:
                                            case 1:
                                            case 2:
                                                button1.Invoke((MethodInvoker)delegate
                                                {
                                                    button1.Enabled = true;
                                                });
                                                break;
                                            default:
                                                button1.Invoke((MethodInvoker)delegate
                                                {
                                                    button1.Enabled = false;
                                                });
                                                break;
                                        }

                                    });
                                    break;
                                
                                default:
                                    label3.Invoke((MethodInvoker)delegate
                                    {
                                        label3.ForeColor = SystemColors.ControlDark;
                                    });
                                    comboBox3.Invoke((MethodInvoker)delegate
                                    {
                                        comboBox3.Enabled = false;
                                    });
                                    button1.Invoke((MethodInvoker)delegate
                                    {
                                        button1.Enabled = false;
                                    });
                                    break;
                            }
                            
                        });
                        label4.Invoke((MethodInvoker)delegate
                        {
                            label4.ForeColor = SystemColors.ControlText;
                        });
                        listBox1.Invoke((MethodInvoker)delegate
                        {
                            listBox1.Enabled = true;
                            if (listBox1.Items.Count != 3)
                            {
                                listBox1.Items.Clear();
                                listBox1.Items.Add("Prince of Persia: The Sands of Time");
                                listBox1.Items.Add("Prince of Persia: Warrior Within");
                                listBox1.Items.Add("Prince of Persia: The Two Thrones");
                            }
                        });
                    }
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void addcategory(string catname)
            {
                TextWriter txt = new StreamWriter("splits.lss", true);
                string data = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<Run version=\"1.7.0\">\n<GameIcon />\n<GameName>Multi-Prince of Persia-Runs</GameName>\n<CategoryName>";
                txt.Write(data);
                txt.Write(catname);
                data = "</CategoryName>\n<Metadata>\n<Run id=\"\" />\n<Platform usesEmulator=\"False\">\n</Platform>\n<Region>\n</Region>\n<Variables />\n</Metadata>\n<Offset>00:00:00</Offset>\n<AttemptCount>0</AttemptCount>\n<AttemptHistory />\n<Segments>\n";
                txt.Write(data);
                txt.Close();
            }
            void addsplit(string splitname)
            {
                TextWriter txt = new StreamWriter("splits.lss", true);
                string data = "<Segment>\n<Name>";
                txt.Write(data);
                txt.Write(splitname);
                data = "</Name>\n<Icon />\n<SplitTimes>\n<SplitTime name=\"Personal Best\" />\n</SplitTimes>\n<BestSegmentTime />\n<SegmentHistory />\n</Segment>\n";
                txt.Write(data);
                txt.Close();
            }
            void setupsplit()
            {
                TextWriter txt = new StreamWriter("splits.lss", true);
                string data = "<Segment>\n<Name>Setup</Name>\n<Icon />\n<SplitTimes>\n<SplitTime name=\"Personal Best\" />\n</SplitTimes>\n<BestSegmentTime />\n<SegmentHistory />\n</Segment>\n";
                txt.Write(data);
                txt.Close();
            }
            void finishfile()
            {
                TextWriter txt = new StreamWriter("splits.lss", true);
                string data = "</Segments>\n<AutoSplitterSettings />\n</Run>";
                txt.Write(data);
                txt.Close();
            }
            void refreshfile()
            {
                TextWriter txt = new StreamWriter("splits.lss");
                string data = "";
                txt.Write(data);
                txt.Close();
            }
            refreshfile();
            label1.Invoke((MethodInvoker)delegate
            {
                label1.ForeColor = SystemColors.ControlDark;
            });
            label2.Invoke((MethodInvoker)delegate
            {
                label2.ForeColor = SystemColors.ControlDark;
            });
            comboBox2.Invoke((MethodInvoker)delegate
            {
                comboBox2.Enabled = true;
            });
            label3.Invoke((MethodInvoker)delegate
            {
                label3.ForeColor = SystemColors.ControlDark;
            });
            comboBox3.Invoke((MethodInvoker)delegate
            {
                comboBox3.Enabled = true;
            });
            button1.Invoke((MethodInvoker)delegate
            {
                button1.Enabled = false;
            });
            label4.Invoke((MethodInvoker)delegate
            {
                label4.ForeColor = SystemColors.ControlDark;
            });
            listBox1.Invoke((MethodInvoker)delegate
            {
                listBox1.Enabled = false;
            });
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    addcategory("Anthology");
                    for (int i = 0; i < 8; i++)
                    {
                        switch (listBox1.Items[i].ToString())
                        {
                            case "Prince of Persia (1989)":
                                addsplit("-Level 1");
                                addsplit("-Level 2");
                                addsplit("-Level 3");
                                addsplit("-Level 4");
                                addsplit("-Level 5");
                                addsplit("-Level 6");
                                addsplit("-Level 7");
                                addsplit("-Level 8");
                                addsplit("-Level 9");
                                addsplit("-Level 10");
                                addsplit("-Level 11");
                                addsplit("-Level 12");
                                addsplit("-Level 13");
                                addsplit("{Prince of Persia (1989)} Level 14");
                                break;
                            
                            case "Prince of Persia 2: The Shadow and the Flame":
                                addsplit("-Level 1");
                                addsplit("-Level 2");
                                addsplit("-Level 3");
                                addsplit("-Level 4");
                                addsplit("-Level 5");
                                addsplit("-Level 6");
                                addsplit("-Level 7");
                                addsplit("-Level 8");
                                addsplit("-Level 9");
                                addsplit("-Level 10");
                                addsplit("-Level 11");
                                addsplit("-Level 12");
                                addsplit("-Level 13");
                                addsplit("{Shadow and the Flame} Level 14");
                                break;

                            case "Prince of Persia 3D":
                                addsplit("-Dungeon");
                                addsplit("-Ivory Tower");
                                addsplit("-Cistern");
                                addsplit("-Palace 1");
                                addsplit("-Palace 2");
                                addsplit("-Palace 3");
                                addsplit("-Rooftops");
                                addsplit("-Streets and Docks");
                                addsplit("-Lower Dirigible 1");
                                addsplit("-Lower Dirigible 2");
                                addsplit("-Upper Dirigible");
                                addsplit("-Dirigible Finale");
                                addsplit("-Floating Ruins");
                                addsplit("-Cliffs");
                                addsplit("-Sun Temple");
                                addsplit("-Moon Temple");
                                addsplit("{Prince of Persia 3D} Finale");
                                break;

                            case "Prince of Persia: The Sands of Time":
                                addsplit("-The Treasure Vaults");
                                addsplit("-The Sands of Time");
                                addsplit("-The Sultan's Chamber (Death)");
                                addsplit("-Death of the Sand King");
                                addsplit("-The Baths (Death)");
                                addsplit("-The Messhall (Death)");
                                addsplit("-The Caves");
                                addsplit("-Exit Underground Reservoir");
                                addsplit("-The Observatory (Death)");
                                addsplit("-The Torture Chamber (Death)");
                                addsplit("-The Dream");
                                addsplit("-Honor and Glory");
                                addsplit("-The Grand Rewind");
                                addsplit("{The Sands of Time} The End");
                                break;

                            case "Prince of Persia: Warrior Within":
                                addsplit("-The Boat");
                                addsplit("-The Raven Man");
                                addsplit("-The Time Portal");
                                addsplit("-Mask of the Wraith (59)");
                                addsplit("-The Scorpion Sword");
                                addsplit("-The Light Sword");
                                addsplit("-Back to the Future");
                                addsplit("{Warrior Within} The End");
                                break;

                            case "Prince of Persia: The Two Thrones":
                                addsplit("-The Ramparts");
                                addsplit("-The Harbour District");
                                addsplit("-The Palace");
                                addsplit("-Exit Sewers");
                                addsplit("-Exit Lower City");
                                addsplit("-The Lower City Rooftops");
                                addsplit("-Exit Temple Rooftops");
                                addsplit("-Exit Marketplace");
                                addsplit("-Exit Plaza");
                                addsplit("-Exit City Gardens");
                                addsplit("-Exit Royal Workshop");
                                addsplit("-The King's Road");
                                addsplit("-Exit Structure's Mind");
                                addsplit("-Exit Labyrith");
                                addsplit("-The Towers");
                                addsplit("-The Terrace");
                                addsplit("{The Two Thrones} The End");
                                break;

                            case "Prince of Persia (2008)":
                                addsplit("-First Fight Skip");
                                addsplit("-Barrier Skip");
                                addsplit("-King's Gate");
                                addsplit("-Sun Temple");
                                addsplit("-Marshalling Grounds");
                                addsplit("-Windmills");
                                addsplit("-Martyrs' Tower");
                                addsplit("-MT -&gt; MG");
                                addsplit("-Machinery Ground");
                                addsplit("-Heaven's Stair");
                                addsplit("-Spire of Dreams");
                                addsplit("-Reservoir");
                                addsplit("-Construction Yard");
                                addsplit("-Cauldron");
                                addsplit("-Cavern");
                                addsplit("-City Gate");
                                addsplit("-Tower of Ormazd");
                                addsplit("-Queen's Tower");
                                addsplit("-The Temple (Arrive)");
                                addsplit("-Double Jump");
                                addsplit("-Wings of Ormazd");
                                addsplit("-The Warrior");
                                addsplit("-Heal Coronation Hall");
                                addsplit("-Coronation Hall");
                                addsplit("-Heal Heaven's Stair");
                                addsplit("-The Alchemist");
                                addsplit("-The Hunter");
                                addsplit("-Hand of Ormazd");
                                addsplit("-The Concubine");
                                addsplit("-The King");
                                addsplit("-The God");
                                addsplit("{Prince of Persia (2008)} Resurrection");
                                break;

                            case "Prince of Persia: The Forgotten Sands":
                                addsplit("-Malik");
                                addsplit("-The Power of Time");
                                addsplit("-The Works");
                                addsplit("-The Courtyard");
                                addsplit("-The Power of Water");
                                addsplit("-The Sewers");
                                addsplit("-Ratash");
                                addsplit("-The Observatory");
                                addsplit("-The Power of Light");
                                addsplit("-The Gardens");
                                addsplit("-The Possession");
                                addsplit("-The Power of Knowledge");
                                addsplit("-The Reservoir");
                                addsplit("-The Power of Razia");
                                addsplit("-The Climb");
                                addsplit("-The Storm");
                                addsplit("{The Forgotten Sands} Grand Finale");
                                break;
                        }
                        if (i != 7)
                            setupsplit();
                    }
                    break;

                case 1:
                    switch (comboBox2.SelectedIndex + 2*comboBox3.SelectedIndex)
                    {
                        case 0:
                            addcategory("Sands Trilogy (Any%, Standard)");
                            for (int i = 0; i < 3; i++)
                            {
                                switch (listBox1.Items[i].ToString())
                                {
                                    case "Prince of Persia: The Sands of Time":
                                        addsplit("-The Treasure Vaults");
                                        addsplit("-The Sands of Time");
                                        addsplit("-The Sultan's Chamber (Death)");
                                        addsplit("-Death of the Sand King");
                                        addsplit("-The Baths (Death)");
                                        addsplit("-The Messhall (Death)");
                                        addsplit("-The Caves");
                                        addsplit("-Exit Underground Reservoir");
                                        addsplit("-The Observatory (Death)");
                                        addsplit("-The Torture Chamber (Death)");
                                        addsplit("-The Dream");
                                        addsplit("-Honor and Glory");
                                        addsplit("-The Grand Rewind");
                                        addsplit("{The Sands of Time} The End");
                                        break;

                                    case "Prince of Persia: Warrior Within":
                                        addsplit("-The Boat");
                                        addsplit("-The Raven Man");
                                        addsplit("-The Time Portal");
                                        addsplit("-Mask of the Wraith (59)");
                                        addsplit("-The Scorpion Sword");
                                        addsplit("-The Light Sword");
                                        addsplit("-Back to the Future");
                                        addsplit("{Warrior Within} The End");
                                        break;

                                    case "Prince of Persia: The Two Thrones":
                                        addsplit("-The Ramparts");
                                        addsplit("-The Harbour District");
                                        addsplit("-The Palace");
                                        addsplit("-Exit Sewers");
                                        addsplit("-Finish Chariot 1");
                                        addsplit("-Arena Deload");
                                        addsplit("-Exit Temple Rooftops");
                                        addsplit("-Exit Marketplace");
                                        addsplit("-Exit Plaza");
                                        addsplit("-Exit City Gardens");
                                        addsplit("-Exit Royal Workshop");
                                        addsplit("-The King's Road");
                                        addsplit("-Well Death");
                                        addsplit("-Cave Death");
                                        addsplit("-The Towers");
                                        addsplit("-The Terrace");
                                        addsplit("{The Two Thrones} The End");
                                        break;
                                }
                                if (i != 2)
                                    setupsplit();
                            }
                            break;
                        case 2:
                            addcategory("Sands Trilogy (Any%, Zipless)");
                            for (int i = 0; i < 3; i++)
                            {
                                switch (listBox1.Items[i].ToString())
                                {
                                    case "Prince of Persia: The Sands of Time":
                                        addsplit("-The Treasure Vaults");
                                        addsplit("-The Sands of Time");
                                        addsplit("-First Guest Room");
                                        addsplit("-The Sultan's Chamber");
                                        addsplit("-Exit Palace Defense");
                                        addsplit("-The Sand King");
                                        addsplit("-Death of the Sand King");
                                        addsplit("-The Warehouse");
                                        addsplit("-The Zoo");
                                        addsplit("-Atop a Bird Cage");
                                        addsplit("-Cliffs and Waterfall");
                                        addsplit("-The Baths");
                                        addsplit("-Sword of the Mighty Warrior");
                                        addsplit("-Daybreak");
                                        addsplit("-Drawbridge Tower");
                                        addsplit("-A Broken Bridge");
                                        addsplit("-The Caves");
                                        addsplit("-Waterfall");
                                        addsplit("-Underground Reservoir");
                                        addsplit("-Hall of Learning");
                                        addsplit("-Exit Observatory");
                                        addsplit("-Exit Hall of Learning Courtyards");
                                        addsplit("-The Prison");
                                        addsplit("-The Torture Chamber");
                                        addsplit("-The Elevator");
                                        addsplit("-The Dream");
                                        addsplit("-The Tomb");
                                        addsplit("-The Tower of Dawn");
                                        addsplit("-The Setting Sun");
                                        addsplit("-Honor and Glory");
                                        addsplit("-The Grand Rewind");
                                        addsplit("{The Sands of Time} The End");
                                        break;

                                    case "Prince of Persia: Warrior Within":
                                        addsplit("-The Boat");
                                        addsplit("-The Raven Man");
                                        addsplit("-The Time Portal");
                                        addsplit("-Mask of the Wraith (59)");
                                        addsplit("-The Scorpion Sword");
                                        addsplit("-The Light Sword");
                                        addsplit("-Back to the Future");
                                        addsplit("{Warrior Within} The End");
                                        break;

                                    case "Prince of Persia: The Two Thrones":
                                        addsplit("-The Ramparts");
                                        addsplit("-The Harbour District");
                                        addsplit("-The Palace");
                                        addsplit("-The Trapped Hallway");
                                        addsplit("-The Sewers");
                                        addsplit("-The Fortress");
                                        addsplit("-The Lower City");
                                        addsplit("-The Lower City Rooftops");
                                        addsplit("-The Balconies");
                                        addsplit("-The Dark Alley");
                                        addsplit("-The Temple Rooftops");
                                        addsplit("-Exit Marketplace");
                                        addsplit("-The Market District");
                                        addsplit("-Exit Plaza");
                                        addsplit("-The Upper City");
                                        addsplit("-The City Gardens");
                                        addsplit("-The Royal Workshop");
                                        addsplit("-The King's Road");
                                        addsplit("-The Palace Entrance");
                                        addsplit("-The Hanging Gardens");
                                        addsplit("-The Structure's Mind");
                                        addsplit("-The Well of Ancestors");
                                        addsplit("-The Labyrinth");
                                        addsplit("-The Lower Tower");
                                        addsplit("-The Upper Tower");
                                        addsplit("-The Terrace");
                                        addsplit("{The Two Thrones} The End");
                                        break;
                                }
                                if (i != 2)
                                    setupsplit();
                            }
                            break;
                        case 4:
                            addcategory("Sands Trilogy (Any%, No Major Glitches)");
                            for (int i = 0; i < 3; i++)
                            {
                                switch (listBox1.Items[i].ToString())
                                {
                                    case "Prince of Persia: The Sands of Time":
                                        addsplit("-The Treasure Vaults");
                                        addsplit("-The Sands of Time");
                                        addsplit("-First Guest Room");
                                        addsplit("-The Sultan's Chamber");
                                        addsplit("-Exit Palace Defense");
                                        addsplit("-The Sand King");
                                        addsplit("-Death of the Sand King");
                                        addsplit("-The Warehouse");
                                        addsplit("-The Zoo");
                                        addsplit("-Atop a Bird Cage");
                                        addsplit("-Cliffs and Waterfall");
                                        addsplit("-The Baths");
                                        addsplit("-Sword of the Mighty Warrior");
                                        addsplit("-Daybreak");
                                        addsplit("-Drawbridge Tower");
                                        addsplit("-A Broken Bridge");
                                        addsplit("-The Caves");
                                        addsplit("-Waterfall");
                                        addsplit("-Underground Reservoir");
                                        addsplit("-Hall of Learning");
                                        addsplit("-Exit Observatory");
                                        addsplit("-Exit Hall of Learning Courtyards");
                                        addsplit("-The Prison");
                                        addsplit("-The Torture Chamber");
                                        addsplit("-The Elevator");
                                        addsplit("-The Dream");
                                        addsplit("-The Tomb");
                                        addsplit("-The Tower of Dawn");
                                        addsplit("-The Setting Sun");
                                        addsplit("-Honor and Glory");
                                        addsplit("-The Grand Rewind");
                                        addsplit("{The Sands of Time} The End");
                                        break;

                                    case "Prince of Persia: Warrior Within":
                                        addsplit("-The Boat");
                                        addsplit("-The Spider Sword");
                                        addsplit("-Chasing Shadee");
                                        addsplit("-A Damsel in Distress");
                                        addsplit("-The Dahaka");
                                        addsplit("-The Serpent Sword");
                                        addsplit("-The Garden Hall");
                                        addsplit("-The Waterworks Restored");
                                        addsplit("-The Lion Sword");
                                        addsplit("-The Mechanical Tower");
                                        addsplit("-Breath of Fate");
                                        addsplit("-Activation Room  in Ruin");
                                        addsplit("-Activation Room Restored");
                                        addsplit("-The Death of a Sand Wraith");
                                        addsplit("-Death of the Empress");
                                        addsplit("-Exit the Tomb");
                                        addsplit("-The Scorpion Sword");
                                        addsplit("-The Library");
                                        addsplit("-The Hourglass Revisited");
                                        addsplit("-Mask of the Wraith");
                                        addsplit("-The Sand Griffin");
                                        addsplit("-Mirrored Fates");
                                        addsplit("-A Favor Unknown");
                                        addsplit("-The Library Revisited");
                                        addsplit("-The Light Sword");
                                        addsplit("-The Death of a Prince");
                                        addsplit("{Warrior Within} The End");
                                        break;

                                    case "Prince of Persia: The Two Thrones":
                                        addsplit("-The Ramparts");
                                        addsplit("-The Harbour District");
                                        addsplit("-The Palace");
                                        addsplit("-The Trapped Hallway");
                                        addsplit("-The Sewers");
                                        addsplit("-The Fortress");
                                        addsplit("-The Lower City");
                                        addsplit("-The Lower City Rooftops");
                                        addsplit("-The Balconies");
                                        addsplit("-The Dark Alley");
                                        addsplit("-The Temple Rooftops");
                                        addsplit("-The Temple");
                                        addsplit("-The Marketplace");
                                        addsplit("-The Market District");
                                        addsplit("-The Brothel");
                                        addsplit("-The Plaza");
                                        addsplit("-The Upper City");
                                        addsplit("-The City Gardens");
                                        addsplit("-The Promenade");
                                        addsplit("-The Royal Workshop");
                                        addsplit("-The King's Road");
                                        addsplit("-The Palace Entrance");
                                        addsplit("-The Hanging Gardens");
                                        addsplit("-The Structure's Mind");
                                        addsplit("-The Well of Ancestors");
                                        addsplit("-The Labyrinth");
                                        addsplit("-The Underground Cave");
                                        addsplit("-The Lower Tower");
                                        addsplit("-The Middle Tower");
                                        addsplit("-The Upper Tower");
                                        addsplit("-The Terrace");
                                        addsplit("{The Two Thrones} The End");
                                        break;
                                }
                                if (i != 2)
                                    setupsplit();
                            }
                            break;
                        case 1:
                            addcategory("Sands Trilogy (Completionist, Standard)");
                            for (int i = 0; i < 3; i++)
                            {
                                switch (listBox1.Items[i].ToString())
                                {
                                    case "Prince of Persia: The Sands of Time":
                                        addsplit("-The Treasure Vaults");
                                        addsplit("-The Sands of Time");
                                        addsplit("-Life Upgrade 1");
                                        addsplit("-Life Upgrade 2");
                                        addsplit("-Life Upgrade 3");
                                        addsplit("-The Baths (Death)");
                                        addsplit("-Life Upgrade 4");
                                        addsplit("-The Messhall (Death)");
                                        addsplit("-Life Upgrade 5");
                                        addsplit("-The Caves (Death)");
                                        addsplit("-Life Upgrade 6");
                                        addsplit("-Life Upgrade 7");
                                        addsplit("-The Observatory (Death)");
                                        addsplit("-Life Upgrade 8");
                                        addsplit("-Life Upgrade 9");
                                        addsplit("-The Dream");
                                        addsplit("-Life Upgrade 10");
                                        addsplit("-Honor and Glory");
                                        addsplit("-The Grand Rewind");
                                        addsplit("{The Sands of Time} The End");
                                        break;

                                    case "Prince of Persia: Warrior Within":
                                        addsplit("-The Boat");
                                        addsplit("-The Raven Man");
                                        addsplit("-Life Upgrade 1");
                                        addsplit("-Life Upgrade 2");
                                        addsplit("-Life Upgrade 3");
                                        addsplit("-Life Upgrade 4");
                                        addsplit("-Life Upgrade 5");
                                        addsplit("-Life Upgrade 6");
                                        addsplit("-Life Upgrade 7");
                                        addsplit("-Life Upgrade 8");
                                        addsplit("-Life Upgrade 9");
                                        addsplit("-The Water Sword");
                                        addsplit("{Warrior Within} The End");
                                        break;

                                    case "Prince of Persia: The Two Thrones":
                                        addsplit("-The Ramparts");
                                        addsplit("-The Harbour District");
                                        addsplit("-The Palace");
                                        addsplit("-Life Upgrade 1");
                                        addsplit("-Exit Lower City");
                                        addsplit("-Life Upgrade 2");
                                        addsplit("-The Arena");
                                        addsplit("-Exit Temple Rooftops");
                                        addsplit("-Life Upgrade 3");
                                        addsplit("-The Marketplace");
                                        addsplit("-Exit Plaza");
                                        addsplit("-Life Upgrade 4");
                                        addsplit("-Exit Royal Workshop");
                                        addsplit("-The King's Road");
                                        addsplit("-Life Upgrade 5");
                                        addsplit("-Exit Structure's Mind");
                                        addsplit("-Exit Labyrith");
                                        addsplit("-Life Upgrade 6");
                                        addsplit("-The Upper Tower");
                                        addsplit("-The Terrace");
                                        addsplit("{The Two Thrones} The End");
                                        break;
                                }
                                if (i != 2)
                                    setupsplit();
                            }
                            break;
                        case 3:
                            addcategory("Sands Trilogy (Completionist, Zipless)");
                            for (int i = 0; i < 3; i++)
                            {
                                switch (listBox1.Items[i].ToString())
                                {
                                    case "Prince of Persia: The Sands of Time":
                                        addsplit("-The Treasure Vaults");
                                        addsplit("-The Sands of Time");
                                        addsplit("-First Guest Room");
                                        addsplit("-Life Upgrade 1");
                                        addsplit("-Exit Palace Defense");
                                        addsplit("-Life Upgrade 2");
                                        addsplit("-Death of the Sand King");
                                        addsplit("-Life Upgrade 3");
                                        addsplit("-The Zoo");
                                        addsplit("-Atop a Bird Cage");
                                        addsplit("-Cliffs and Waterfall");
                                        addsplit("-The Baths");
                                        addsplit("-Life Upgrade 4");
                                        addsplit("-Daybreak");
                                        addsplit("-Drawbridge Tower");
                                        addsplit("-A Broken Bridge");
                                        addsplit("-Life Upgrade 5");
                                        addsplit("-Waterfall");
                                        addsplit("-Underground Reservoir");
                                        addsplit("-Life Upgrade 6");
                                        addsplit("-Hall of Learning");
                                        addsplit("-Life Upgrade 7");
                                        addsplit("-Exit Observatory");
                                        addsplit("-Exit Hall of Learning Courtyards");
                                        addsplit("-The Prison");
                                        addsplit("-Life Upgrade 8");
                                        addsplit("-Life Upgrade 9");
                                        addsplit("-The Dream");
                                        addsplit("-The Tomb");
                                        addsplit("-Life Upgrade 10");
                                        addsplit("-The Tower of Dawn");
                                        addsplit("-The Setting Sun");
                                        addsplit("-Honor and Glory");
                                        addsplit("-The Grand Rewind");
                                        addsplit("{The Sands of Time} The End");
                                        break;

                                    case "Prince of Persia: Warrior Within":
                                        addsplit("-The Boat");
                                        addsplit("-The Raven Man");
                                        addsplit("-Life Upgrade 1");
                                        addsplit("-Life Upgrade 2");
                                        addsplit("-Life Upgrade 3");
                                        addsplit("-Life Upgrade 4");
                                        addsplit("-Mask of the Wraith (59)");
                                        addsplit("-Life Upgrade 5");
                                        addsplit("-Life Upgrade 6");
                                        addsplit("-The Mechanical Tower");
                                        addsplit("-Life Upgrade 7");
                                        addsplit("-Life Upgrade 8");
                                        addsplit("-Life Upgrade 9");
                                        addsplit("-The Water Sword");
                                        addsplit("{Warrior Within} The End");
                                        break;

                                    case "Prince of Persia: The Two Thrones":
                                        addsplit("-The Ramparts");
                                        addsplit("-The Harbour District");
                                        addsplit("-The Palace");
                                        addsplit("-The Trapped Hallway");
                                        addsplit("-Life Upgrade 1");
                                        addsplit("-The Fortress");
                                        addsplit("-The Lower City");
                                        addsplit("-Life Upgrade 2");
                                        addsplit("-The Arena");
                                        addsplit("-The Balconies");
                                        addsplit("-The Dark Alley");
                                        addsplit("-The Temple Rooftops");
                                        addsplit("-Life Upgrade 3");
                                        addsplit("-The Marketplace");
                                        addsplit("-The Market District");
                                        addsplit("-Exit Plaza");
                                        addsplit("-The Upper City");
                                        addsplit("-Life Upgrade 4");
                                        addsplit("-The Royal Workshop");
                                        addsplit("-The King's Road");
                                        addsplit("-Life Upgrade 5");
                                        addsplit("-The Hanging Gardens");
                                        addsplit("-The Structure's Mind");
                                        addsplit("-The Well of Ancestors");
                                        addsplit("-The Labyrinth");
                                        addsplit("-The Lower Tower");
                                        addsplit("-Life Upgrade 6");
                                        addsplit("-The Upper Tower");
                                        addsplit("-The Terrace");
                                        addsplit("{The Two Thrones} The End");
                                        break;
                                }
                                if (i != 2)
                                    setupsplit();
                            }
                            break;
                        case 5:
                            addcategory("Sands Trilogy (Completionist, No Major Glitches)");
                            for (int i = 0; i < 3; i++)
                            {
                                switch (listBox1.Items[i].ToString())
                                {
                                    case "Prince of Persia: The Sands of Time":
                                        addsplit("-The Treasure Vaults");
                                        addsplit("-The Sands of Time");
                                        addsplit("-First Guest Room");
                                        addsplit("-Life Upgrade 1");
                                        addsplit("-Exit Palace Defense");
                                        addsplit("-Life Upgrade 2");
                                        addsplit("-Death of the Sand King");
                                        addsplit("-Life Upgrade 3");
                                        addsplit("-The Zoo");
                                        addsplit("-Atop a Bird Cage");
                                        addsplit("-Cliffs and Waterfall");
                                        addsplit("-The Baths");
                                        addsplit("-Life Upgrade 4");
                                        addsplit("-Daybreak");
                                        addsplit("-Drawbridge Tower");
                                        addsplit("-A Broken Bridge");
                                        addsplit("-Life Upgrade 5");
                                        addsplit("-Waterfall");
                                        addsplit("-Underground Reservoir");
                                        addsplit("-Life Upgrade 6");
                                        addsplit("-Hall of Learning");
                                        addsplit("-Life Upgrade 7");
                                        addsplit("-Exit Observatory");
                                        addsplit("-Exit Hall of Learning Courtyards");
                                        addsplit("-The Prison");
                                        addsplit("-Life Upgrade 8");
                                        addsplit("-Life Upgrade 9");
                                        addsplit("-The Dream");
                                        addsplit("-The Tomb");
                                        addsplit("-Life Upgrade 10");
                                        addsplit("-The Tower of Dawn");
                                        addsplit("-The Setting Sun");
                                        addsplit("-Honor and Glory");
                                        addsplit("-The Grand Rewind");
                                        addsplit("{The Sands of Time} The End");
                                        break;

                                    case "Prince of Persia: Warrior Within":
                                        addsplit("-The Boat");
                                        addsplit("-The Spider Sword");
                                        addsplit("-Life Upgrade 1");
                                        addsplit("-A Damsel in Distress");
                                        addsplit("-Life Upgrade 2");
                                        addsplit("-The Dahaka");
                                        addsplit("-Life Upgrade 3");
                                        addsplit("-The Serpent Sword");
                                        addsplit("-The Waterworks Restored");
                                        addsplit("-Life Upgrade 4");
                                        addsplit("-Life Upgrade 5");
                                        addsplit("-Life Upgrade 6");
                                        addsplit("-The Mechanical Tower");
                                        addsplit("-Breath of Fate");
                                        addsplit("-Activation Room  in Ruin");
                                        addsplit("-Life Upgrade 7");
                                        addsplit("-The Death of a Sand Wraith");
                                        addsplit("-Death of the Empress");
                                        addsplit("-Exit the Tomb");
                                        addsplit("-The Scorpion Sword");
                                        addsplit("-Life Upgrade 8");
                                        addsplit("-Life Upgrade 9");
                                        addsplit("-The Water Sword");
                                        addsplit("-Mask of the Wraith");
                                        addsplit("-The Sand Griffin");
                                        addsplit("-Mirrored Fates");
                                        addsplit("-A Favor Unknown");
                                        addsplit("-The Library Revisited");
                                        addsplit("-The Light Sword");
                                        addsplit("-The Death of a Prince");
                                        addsplit("{Warrior Within} The End");
                                        break;

                                    case "Prince of Persia: The Two Thrones":
                                        addsplit("-The Ramparts");
                                        addsplit("-The Harbour District");
                                        addsplit("-The Palace");
                                        addsplit("-The Trapped Hallway");
                                        addsplit("-Life Upgrade 1");
                                        addsplit("-The Fortress");
                                        addsplit("-The Lower City");
                                        addsplit("-Life Upgrade 2");
                                        addsplit("-The Arena");
                                        addsplit("-The Balconies");
                                        addsplit("-The Dark Alley");
                                        addsplit("-The Temple Rooftops");
                                        addsplit("-Life Upgrade 3");
                                        addsplit("-The Marketplace");
                                        addsplit("-The Market District");
                                        addsplit("-The Brothel");
                                        addsplit("-The Plaza");
                                        addsplit("-The Upper City");
                                        addsplit("-The City Gardens");
                                        addsplit("-The Promenade");
                                        addsplit("-The Royal Workshop");
                                        addsplit("-The King's Road");
                                        addsplit("-Life Upgrade 5");
                                        addsplit("-The Hanging Gardens");
                                        addsplit("-The Structure's Mind");
                                        addsplit("-The Well of Ancestors");
                                        addsplit("-The Labyrinth");
                                        addsplit("-The Underground Cave");
                                        addsplit("-The Lower Tower");
                                        addsplit("-Life Upgrade 6");
                                        addsplit("-The Upper Tower");
                                        addsplit("-The Terrace");
                                        addsplit("{The Two Thrones} The End");
                                        break;
                                }
                                if (i != 2)
                                    setupsplit();
                            }
                            break;
                    }
                    break;
            }
            finishfile();
            label1.Invoke((MethodInvoker)delegate
            {
                label1.ForeColor = SystemColors.ControlText;
            });
            label2.Invoke((MethodInvoker)delegate
            {
                label2.ForeColor = SystemColors.ControlText;
            });
            comboBox2.Invoke((MethodInvoker)delegate
            {
                comboBox2.Enabled = true;
            });
            label3.Invoke((MethodInvoker)delegate
            {
                label3.ForeColor = SystemColors.ControlText;
            });
            comboBox3.Invoke((MethodInvoker)delegate
            {
                comboBox3.Enabled = true;
            });
            button1.Invoke((MethodInvoker)delegate
            {
                button1.Enabled = true;
            });
            label4.Invoke((MethodInvoker)delegate
            {
                label4.ForeColor = SystemColors.ControlText;
            });
            listBox1.Invoke((MethodInvoker)delegate
            {
                listBox1.Enabled = true;
            });
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.listBox1.SelectedItem == null) return;
            this.listBox1.DoDragDrop(this.listBox1.SelectedItem, DragDropEffects.Move);
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBox1.PointToClient(new Point(e.X, e.Y));
            int index = this.listBox1.IndexFromPoint(point);
            if (index < 0) index = this.listBox1.Items.Count - 1;
            object data = e.Data.GetData(typeof(String));
            this.listBox1.Items.Remove(data);
            this.listBox1.Items.Insert(index, data);
        }
    }
}
