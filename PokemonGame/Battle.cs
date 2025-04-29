using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGame
{                                                  
    public partial class Battle : Form //ZL
    {
        private List<PictureBox> CPUpokemon;
        private List<Image> PlayerPokemon;
        private Dictionary<Image, List<String>> PlayerPokeAndMoves;

        //private Dictionary<PictureBox, List<String>> CPUPokeAndMove;

        private List<Button> Move;

        private bool whoTurn;

        private int speed1, speed2, attack1, attack2, health1, health2, defense1, defense2 = 0;

        private Image imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos;


        public Battle(Image tm1BackgroundImage1, Image tm1BackgroundImage2, Image tm1BackgroundImage3, Image tm1BackgroundImage4, Image tm1BackgroundImage5, Image tm1BackgroundImage6, Image butCharizard, Image butBlaziken, Image butBlastoise, Image butBarbaracle, Image butIncineroar, Image butAerodactyl, Image butArticuno, Image butDragapult, Image butDragonite, Image butFroslass, Image butGardevoir, Image butGengar, Image butGroudon, Image butKrookodile, Image butKyogre, Image butLucario, Image butGarchomp, Image butMewtwo, Image butPikachu, Image butSceptile, Image butShedinja, Image butSteelix, Image butSylveon, Image butTalonflame, Image butToxapex, Image butToxicroak, Image butTyranitar, Image butVenusaur, Image butVikavolt, Image butZapdos)
        {
            InitializeComponent();
            
            imgCharizard = butCharizard;
            imgBlaziken = butBlaziken;
            imgBlastoise = butBlastoise;
            imgBarbaracle = butBarbaracle;
            imgIncineroar = butIncineroar;
            imgAerodactyl = butAerodactyl;
            imgArticuno = butArticuno;
            imgDragapult = butDragapult;
            imgDragonite = butDragonite;
            imgFroslass = butFroslass;
            imgGarchomp = butGarchomp;
            imgGardevoir = butGardevoir;
            imgGengar = butGengar;
            imgGroudon = butGroudon;
            imgKrookodile = butKrookodile;
            imgKyogre = butKyogre;
            imgLucario = butLucario;
            imgMewtwo = butMewtwo;
            imgPikachu = butPikachu;
            imgSceptile = butSceptile;
            imgShedinja = butShedinja;
            imgSteelix = butSteelix;
            imgSylveon = butSylveon;
            imgTalonflame = butTalonflame;
            imgToxapex = butToxapex;
            imgToxicroak = butToxicroak;
            imgTyranitar = butTyranitar;
            imgVenusaur = butVenusaur;
            imgVikavolt = butVikavolt;
            imgZapdos = butZapdos;
<<<<<<< HEAD
            //ZL

=======

            
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a

            //Set health
            //EC
            Move = new List<Button> { Move1, Move2, Move3, Move4 };
            //Array Lists of Computer Pokemon and Player Pokemon
            CPUpokemon = new List<PictureBox>() { team2Poke, team2Poke2, team2Poke3, team2Poke4, team2Poke5, team2Poke6 };
            PlayerPokemon = new List<Image>() { tm1BackgroundImage1, tm1BackgroundImage2, tm1BackgroundImage3, tm1BackgroundImage4, tm1BackgroundImage5, tm1BackgroundImage6 };

            PlayerPokeAndMoves = new Dictionary<Image, List<String>>();

            CPUHealth.Maximum = 404;
            CPUHealth.Minimum = 0;
            PlayerHealth.Maximum = 404;
            PlayerHealth.Minimum = 0;

<<<<<<< HEAD
            //EC

=======
            team1Poke.Image = PlayerPokemon[0];
            team1Poke2.Image = PlayerPokemon[1];
            team1Poke3.Image = PlayerPokemon[2];
            team1Poke4.Image = PlayerPokemon[3];
            team1Poke5.Image = PlayerPokemon[4];
            team1Poke6.Image = PlayerPokemon[5];
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
            /*if (CPUpokemon[0].BackgroundImage == butAerodactyl)
            {
                String move;
                int selectMove;
                //type: rock and water
                //weak against rock, electric, water, steel, ice
                //cannot be hit by ground type moves
                //resist normal, fire, poison, flying, bug
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Taunt", "Stealth Rock", "Stone Edge", "Aeiral Ace" };
                // Stone Edge 80% accuracy
                //Aeiral Ace 100% accuracy

                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                CPUPokeAndMove[CPUpokemon[0]][selectMove];

                if (move == "Taunt")
                {

                }
                else if (move == "Stealth Rock")
                {

                }
                else if (move == "Stone Edge")
                {

                }
                else if (move == "Aeiral Ace")
                {

                }
            }
            else if (CPUpokemon[0].BackgroundImage == butArticuno)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Brave Bird", "Hurricane", "Ice Shard", "Frost Breath" };
                //Brave Bird Flying 120 damage, special 1/3 of the damage to the user
                //Hurricane Flying type, 130 damage 70% accuracy, 30% confussion
                //Ice Shard Ice type, 40 damage
                //Frost Breath always a crit hit, 60 damage, 90% accuracy
                //Weaknesses 4x rock, 2x fire, electric, and steel
                //0.5, grass and bug
                //Immune to ground
            }
            else if (CPUpokemon[0].BackgroundImage == butBarbaracle)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Shell Smash", "Dragon Claw", "Razor Shell", "Stone Edge" };
                //Dragon Claw 80 damage, 100% accuracy
                //Razor Shell 95% accuracy, 75 damage
                //4x grass, 2x electric, 2x fighting, 2x ground <- weaknesses
                //0.5x normal, ice, poision, flying
                // 0.25x fire
                // Stone Edge 80% accuracy
            }
            else if (CPUpokemon[0].BackgroundImage == butBlastoise)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Water Pulse", "Aura Sphere", "Dragon Pulse", "Dark Pulse" };
                //Water pulse 60 damage, 20% confusion
                //Aura Sphere fighitng, 80 damage, 100% acc
                //Dragon Pulse dragon, 85 damage
                //Dark dark, 80 damage
                //Weaknesses 2x electric and grass
                //0.5x fire, water, ice, and steel
            }
            else if (CPUpokemon[0].BackgroundImage == butBlaziken)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Stone Edge", "Hone Claws", "Blaze Kick", "High Jump Kick" };
                //Stone Edge 80% accuracy
                //Hone Claws raise attack
                //Blaze Kick fire type, 85 damage, 90% acc
                //High Jump Kick fighting type, if misses half health to yourself, 100 damage, 85% acc
                //Weaknesses 2x water, ground, flying, psychic
                //0.5x fire, grass, ice, dark, steel
                //0.25 bug

            }
            else if (CPUpokemon[0].BackgroundImage == butCharizard)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Earthquake", "Dragon Claw", "Dragon Dance", "Fire Blitz" };
                //Earthquake ground, 100 damage
                //Dragon Claw 80 damage, 100% accuracy
                //Dragon Dance raises attack, and speed, by one stage
                //Fire Blitz fire, hits, 120 damage, 1/3 of damage to user (brave bird but fire)
                //Weakness 4x rock, 2x water and electric,
                //0.5x fire, fighting, steel, fairy,
                //0.25x grass, bug
                //immune ground

            }
            else if (CPUpokemon[0].BackgroundImage == butDragapult)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Dragon Darts", "Dragon Dance", "Night Shade", "Shadow Ball" };
                //Dragon Darts Dragon type, 100 damage
                //Dragon Dance raises attack, and speed, by one stage
                //Night Shade 50 damage
                //Shadow Ball ghost type, 20% chance to raise attack, 80 dmg
                //Weakness 2x ice, ghost, dragon, dark, fairy
                //0.5x fire, water, electic, grass, posion, bug
                //Immune cannot be hit by normal or fighting
            }
            else if (CPUpokemon[0].BackgroundImage == butKrookodile)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Outrage", "Earthquake", "Crunch", "Stone Edge" };
                //Outrage:
                //Stone Edge 80% accuracy
                //Earthquake ground, 100 damage
                //Crunch Dark type move, 80 damage
                //Weaknesses 2x water, grass, ice, fighting, bug, and fairy
                //0.5x poision, rock, ghost, and dark
                //Immune (not hit) electric, and psychic
            }
            else if (CPUpokemon[0].BackgroundImage == butKyogre)
            {

                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Water Spout", "Thunder", "Ice beam", "Origin Pulse" };
                //Water spout (150 x crhp) / hpmax
                //Thunder 3/10 chance for par, 110 damage, 70% acc
                //Ice Beam Ice type, 10% freeze, 90 damage
                //Origin Pulse 180 damage, 80% acc
                //Weaknesses 2x electric and grass
                //0.5x fire, water, ice, and steel
            }
            else if (CPUpokemon[0].BackgroundImage == butMewtwo)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Aura Sphere", "Thunder", "Shadow Ball", "Ice Beam" };
                //Aura Sphere fighitng, 80 damage, 100% acc
                //Thunder 3/10 chance for par, 110 damage, 70% acc
                //Ice Beam Ice type, 10% freeze, 90 damage
                //Shadow Ball ghost type, 20 % chance to raise attack, 80 dmg
                //Weakness 2x bug, ghost, dark
                //0.5 fighting and psychic
            }
            else if (CPUpokemon[0].BackgroundImage == butPikachu)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Brick Break", "Thunderbolt", "Thunder Punch", "Quick Attack" };
                //Brick Break fighting type, 75 dmh
                //Thunder type elctric, 10% par, 90 dmg
                //Thunder Punc 10% par, 75 dmg
                //Quick Attack  40 damage, always hits first (set speed nuts cause why not)
                //Weakness 2x ground
                //0.5x electric flying and steel
            }
            else if (CPUpokemon[0].BackgroundImage == butSceptile)
            {
                //Grass Type
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Hone Claws", "Leaf Blade", "Dynamic Punch", "Rock Slide" };
                //Leaf Blade grass, 90 dmg, crit 1/8
                //Dynamic Punch, 100% confussion, 100 dmg, 50% acc
                //Rock Slide rock, 75 dmg, 90% acc
                //Weakness 2x fire, ice, posion, flying, bug
                //0.5 water, electric, grass, ground
            }
            else if (CPUpokemon[0].BackgroundImage == butShedinja)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Shadow Snake", "Sword Stance", "Giga Impact", "X-Scissor" };
                //Shadow Snake ghost type, always goes first, 40dmg
                //Sword Stanceraises attack 2 stages
                //giga impact, normal type, no turn next run, 150 dmg, 90% acc
                //X-Scissior bug type, 80 dmg
                //Can only be hit by fire, flyimg, rock, ghost, dark
                //Immune to everything else ^
            }
            else if (CPUpokemon[0].BackgroundImage == butVenusaur)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Solar Beam", "Earthquake", "Hidden Power", "Growth" };
                //Solar Beam damage on second turn 120 dmg, grass type
                //Hidden Power fire type, 60 dmg
                //Growth raises attack by one stage
                //Weakness 2x fire, ice, flying, psychic
                //0.5x water, electric, fighting, fairy
                //0.25x grass
            }
            else if (CPUpokemon[0].BackgroundImage == butDragonite)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Dragon Dance", "Roost", "Dragon Claw", "Fire Punch" };
                //Roost restores half of users max hp
                //Fire Punch 10% burn,
                //Weak 4x ice, 2x rock, dragon, fairy
                //0.5x fire, water, fighting, and bug
                //0.25x grass
                //Immune to ground
            }
            else if (CPUpokemon[0].BackgroundImage == butFroslass)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Shadow Claw", "Thunder Wave", "Shadow Ball", "Ice Beam" };
                //Shadow Claw Ghost Type, 70 damage
                //Thunder Wave 100% par
                //weak 2x fire, rock, ghost, dark, steel
                //0.5 ice, poision, bug
            }
            else if (CPUpokemon[0].BackgroundImage == butGarchomp)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Sword Stance", "Earthquake", "Dragon Claw", "Outrage" };
                //weakness 4x ice, 2x dragon, and fiary
                //0.5 fire poision and rock
                //immune to electric
            }
            else if (CPUpokemon[0].BackgroundImage == butGardevoir)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Psychic", "Thunderboly", "Shadow Ball", "Misty Explosion" };
                //Psychic 10% raise attack, 90dmg
                //Misty Explosion 100 dmg
                //Weak 2x posions, ghost, and steel
                //0.5x psychic
                //0.25x fighting
                //Immune to dragon
            }
            else if (CPUpokemon[0].BackgroundImage == butGengar)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Shadow Ball", "Thunderbolt", "Poltergeist", "Sludge Ball" };
                //Poltergiest 100dmg, 90%acc, can only use 5 times
                //Sludge Ball poision type, 30% posion, 90 dmg
                //weak 2x ground, psychic, ghost, and dark
                //0.5x grass and fiary
                //0.25 posion and bug
                //immune to normal and fighting
            }
            else if (CPUpokemon[0].BackgroundImage == butGroudon)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Fire Blast", "Earthquake", "Stone Edge", "Solar Beam" };
                //fire blast fire type, 10% burn, 110 damage, 85% acc
                //weak 2x water, grass, ice
                //0.5 poision, rock
                //Immune to electric
            }
            else if (CPUpokemon[0].BackgroundImage == butIncineroar)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Darkest Lariat", "Flame Charge", "Earthquake", "Sword Stance" };
                //Darkest Lariat dark type, 85 dmg, hits, ignores if paralyzed or high def
                //Flame Charge fire type, raises speed by one stage, 50 dmg
                //Weak 2x water, ground and rock, fighting
                //0.5 fire, grass, ice, ghost, dark, and steel
                //immune psychic
            }
            else if (CPUpokemon[0].BackgroundImage == butLucario)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Sword Stance", "High Jump Kick", "Shadow Claw", "Ice Punch" };
                //Ice Punch 75 dmg
                //weak 2x fire, fighting, and ground
                //half to noraml,grass,ice,dragon,dark, and steel
                //quarter to bug and rock
                //immune to posion
            }
            else if (CPUpokemon[0].BackgroundImage == butSteelix)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Iron Tail", "Earthquake", "Rock Slide", "Crunch" };
                //Iron Tail steel type, 30% raise attack by one stage, 100 dmg, 75% acc
                //Rock Slide rock type, 30% flinch, 75dmg, 90% acc
                //Crunch dark type, 20% attack by one stage, 80dmg, hits
                //weak 2x fire, water, fighting, ground
                //0.5 to normal, flying, psychic, bug, dragon, steel, and fairy
                //0.25 rock
                //immune to elxtric and posion
            }
            else if (CPUpokemon[0].BackgroundImage == butSylveon)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Hypervoice", "Psyschock", "Shadow Ball", "Calm mind" };
                //Psyshock 80 dmg
                //Calm mind raises attack by one stage
                //weak 2x poision, steel
                //0.5 fighitng, bug, dark
                //immune to dragon
            }
            else if (CPUpokemon[0].BackgroundImage == butTalonflame)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Sword Stance", "Hurricane", "Flair Blitz", "Roost" };
                //Flair Blitz 120 dmg, causes 0.25 damage of its max health to itself, 100% accurate
                //weaknesses 4x rock, 2x water, electic
                //0.5 fire fighting, steel, and fairy
                //0.25 grass and bug
                //immune to ground

            }
            else if (CPUpokemon[0].BackgroundImage == butToxapex)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Gunk Shot", "Scald", "Liquidation", "Mud Slap" };
                //Gunk Shot poision type move, 120 dmg, 80% acc
                //Scald water, 30% burning, 80 dmg
                //Liquidation water, 20% lowering defence by one stage, 85 dmg
                //Mud Slap ground, 20dmg
                //weak 2x electric, ground, psychic
                //0.5x fire, water, ice, fighting, posion, bug, steel, fairy

            }
            else if (CPUpokemon[0].BackgroundImage == butToxicroak)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Acid Spray", "Gunk Shot", "Mud Slap", "Ice Punch" };
                //Acid Spray lowers def by 2 stages
                //weak 4x psychic, 2x ground and flying
                //0.5x grass, fighiting, posion, rock , dark
                //0.25 bug
            }
            else if (CPUpokemon[0].BackgroundImage == butTyranitar)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Fire Punch", "Dragon Dnace", "Stone Edge", "Ice Punch" };
                //weak 4x fighting, 2x water, grass, ground, steel, bug, fairy
                //0.5 normal, fire, poision, flying, ghost, and dark
                //Immune Psychic
            }
            else if (CPUpokemon[0].BackgroundImage == butVikavolt)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Bug Buzz", "Thunder", "Flash Cannon", "Crunch" };
                //Bug Buzz bug type 90 damage, 10% lowering def by one stage
                //Flash Cannon steel type, 80 dmg, 10% lowering def by one stage
                //weak 2x fire, rock
                //0.5x electric grass, fighting and steel
            }
            else if (CPUpokemon[0].BackgroundImage == butZapdos)
            {
                CPUPokeAndMove[CPUpokemon[0]] = new List<String> { "Thunderbolt", "Thunder", "Roost", "Gunk Shot" };
                //weak 2x ice and rock
                //0.5 grass, fighting, flying, bug, and steel
                //immune to ground
            }
            */

            //To Show players first pokemon in battle
<<<<<<< HEAD
            team1Poke.BackgroundImage = PlayerPokemon[0];
            team1Poke2.BackgroundImage = PlayerPokemon[1];
            team1Poke3.BackgroundImage = PlayerPokemon[2];
            team1Poke4.BackgroundImage = PlayerPokemon[3];
            team1Poke5.BackgroundImage = PlayerPokemon[4];
            team1Poke6.BackgroundImage = PlayerPokemon[5];
=======
            
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a

            //team 2 and 2 speed, attack, and health variables
            int speed1, speed2, attack1, attack2, health1, health2, defense1, defense2 = 0;

            //Randomly selecting computer team
            //MS,ZL,JM,EC
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                int ranNum = rnd.Next(1, 30);
                if (ranNum == 1)
                {
<<<<<<< HEAD
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butCharizard;
                        speed2 = 100;
                        attack2 = 84;
                        health2 = 78;
                        defense2 = 78;

                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butCharizard;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butCharizard;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butCharizard;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butCharizard;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butCharizard;
                    }

                }
                else if (ranNum == 2)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butBlaziken;
                        speed2 = 80;
                        attack2 = 120;
                        health2 = 80;
                        defense2 = 70;
=======
                    speed2 = 100;
                    attack2 = 84;
                    health2 = 78;
                    defense2 = 78;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butCharizard;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke2.BackgroundImage == null)
                    {
<<<<<<< HEAD
                        team2Poke2.BackgroundImage = butBlaziken;
=======
                        team2Poke2.Image = butCharizard;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
<<<<<<< HEAD
                        team2Poke3.BackgroundImage = butBlaziken;
=======
                        team2Poke3.Image = butCharizard;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
<<<<<<< HEAD
                        team2Poke4.BackgroundImage = butBlaziken;
=======
                        team2Poke4.Image = butCharizard;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
<<<<<<< HEAD
                        team2Poke5.BackgroundImage = butBlaziken;
=======
                        team2Poke5.Image = butCharizard;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
<<<<<<< HEAD
                        team2Poke6.BackgroundImage = butBlaziken;
                    }


                }
                else if (ranNum == 3)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butBlastoise;
                        speed2 = 78;
                        attack2 = 83;
                        health2 = 79;
                        defense2 = 100;

                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();

                    }
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butBlastoise;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butBlastoise;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butBlastoise;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butBlastoise;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butBlastoise;
=======
                        team2Poke6.Image = butCharizard;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    
                }
                else if (ranNum == 2)
                {
                    speed2 = 80;
                    attack2 = 120;
                    health2 = 80;
                    defense2 = 70;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butBlaziken;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butBlaziken;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butBlaziken;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butBlaziken;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butBlaziken;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butBlaziken;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }

                }
                else if (ranNum == 3)
                {
                    speed2 = 78;
                    attack2 = 83;
                    health2 = 79;
                    defense2 = 100;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butBlastoise;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butBlastoise;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butBlastoise;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butBlastoise;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butBlastoise;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butBlastoise;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }

                }
                else if (ranNum == 4)
                {
<<<<<<< HEAD
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butBarbaracle;
                        speed2 = 68;
                        attack2 = 105;
                        health2 = 72;
                        defense2 = 115;

=======
                    speed2 = 68;
                    attack2 = 105;
                    health2 = 72;
                    defense2 = 115;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butBarbaracle;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butBarbaracle;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butBarbaracle;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butBarbaracle;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butBarbaracle;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butBarbaracle;
                    }

                }
                else if (ranNum == 5)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butIncineroar;
                        speed2 = 60;
                        attack2 = 115;
                        health2 = 105;
                        defense2 = 90;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butBarbaracle;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butBarbaracle;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butBarbaracle;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butBarbaracle;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butBarbaracle;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                
                }
                else if (ranNum == 5)
                {
                    speed2 = 240;
                    attack2 = 361;
                    health2 = 394;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butIncineroar;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butIncineroar;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butIncineroar;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butIncineroar;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butIncineroar;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butIncineroar;
                    }

                }
                else if (ranNum == 6)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butAerodactyl;
                        speed2 = 130;
                        attack2 = 105;
                        health2 = 80;
                        defense2 = 65;

                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butAerodactyl;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butAerodactyl;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butAerodactyl;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butAerodactyl;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butAerodactyl;
                    }

                }
                else if (ranNum == 7)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butArticuno;
                        speed2 = 85;
                        attack2 = 85;
                        health2 = 90;
                        defense2 = 100;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butIncineroar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butIncineroar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butIncineroar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butIncineroar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butIncineroar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                   
                }
                else if (ranNum == 6)
                {
                    speed2 = 130;
                    attack2 = 105;
                    health2 = 80;
                    defense2 = 65;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butAerodactyl;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butArticuno;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butArticuno;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butArticuno;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butArticuno;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butArticuno;
                    }

                }
                else if (ranNum == 8)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butDragapult;
                        speed2 = 142;
                        attack2 = 120;
                        health2 = 88;
                        defense2 = 75;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butAerodactyl;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butAerodactyl;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butAerodactyl;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butAerodactyl;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butAerodactyl;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }

                }
                else if (ranNum == 7)
                {
                    speed2 = 85;
                    attack2 = 85;
                    health2 = 90;
                    defense2 = 100;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butArticuno;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butDragapult;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butDragapult;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butDragapult;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butDragapult;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butDragapult;
                    }

                }
                else if (ranNum == 9)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butDragonite;
                        speed2 = 80;
                        attack2 = 134;
                        health2 = 91;
                        defense2 = 95;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butArticuno;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butArticuno;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butArticuno;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butArticuno;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butArticuno;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    
                }
                else if (ranNum == 8)
                {
                    speed2 = 142;
                    attack2 = 120;
                    health2 = 88;
                    defense2 = 75;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butDragapult;
                        team2Poke6.Image = butArticuno;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butDragonite;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butDragonite;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butDragonite;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butDragonite;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butDragonite;
                    }

                }
                else if (ranNum == 10)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butFroslass;
                        speed2 = 110;
                        attack2 = 80;
                        health2 = 70;
                        defense2 = 100;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butDragapult;
                        team2Poke6.Image = butArticuno;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butDragapult;
                        team2Poke6.Image = butArticuno;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butDragapult;
                        team2Poke6.Image = butArticuno;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butDragapult;
                        team2Poke6.Image = butArticuno;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butDragapult;
                        team2Poke6.Image = butArticuno;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    

                }
                else if (ranNum == 9)
                {
                    speed2 = 80;
                    attack2 = 134;
                    health2 = 91;
                    defense2 = 95;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butDragonite;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butFroslass;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butFroslass;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butFroslass;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butFroslass;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butFroslass;
                    }

                }
                else if (ranNum == 11)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butGardevoir;
                        speed2 = 80;
                        attack2 = 65;
                        health2 = 103;
                        defense2 = 65;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butDragonite;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butDragonite;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butDragonite;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butDragonite;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butDragonite;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    

                    
                }
                else if (ranNum == 10)
                {
                    speed2 = 110;
                    attack2 = 80;
                    health2 = 70;
                    defense2 = 100;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butFroslass;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butGardevoir;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butGardevoir;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butGardevoir;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butGardevoir;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butGardevoir;
                    }

                }
                else if (ranNum == 12)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butGengar;
                        speed2 = 110;
                        attack2 = 65;
                        health2 = 95;
                        defense2 = 60;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butFroslass;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butFroslass;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butFroslass;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butFroslass;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butFroslass;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
               
                }
                else if (ranNum == 11)
                {
                    speed2 = 80;
                    attack2 = 65;
                    health2 = 103;
                    defense2 = 65;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butGardevoir;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butGengar;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butGengar;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butGengar;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butGengar;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butGengar;
                    }

                }
                else if (ranNum == 13)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butGroudon;
                        speed2 = 90;
                        attack2 = 150;
                        health2 = 115;
                        defense2 = 140;


                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butGroudon;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butGroudon;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butGroudon;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butGroudon;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butGroudon;
                    }

                }
                else if (ranNum == 14)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butKrookodile;
                        speed2 = 92;
                        attack2 = 117;
                        health2 = 115;
                        defense2 = 80;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butGardevoir;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butGardevoir;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butGardevoir;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butGardevoir;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butGardevoir;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    
                }
                else if (ranNum == 12)
                {
                    speed2 = 110;
                    attack2 = 65;
                    health2 = 95;
                    defense2 = 60;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butGengar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butGengar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butGengar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butGengar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butGengar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butGengar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                   
                }
                else if (ranNum == 13)
                {
                    speed2 = 90;
                    attack2 = 150;
                    health2 = 115;
                    defense2 = 140;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butGroudon;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butGroudon;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butGroudon;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butGroudon;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butGroudon;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butGroudon;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    

                }
                else if (ranNum == 14)
                {
                    speed2 = 311;
                    attack2 = 366;
                    health2 = 394;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butKrookodile;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butKrookodile;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butKrookodile;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butKrookodile;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butKrookodile;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butKrookodile;
                    }

                }
                else if (ranNum == 15)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butKyogre;
                        speed2 = 90;
                        attack2 = 100;
                        health2 = 115;
                        defense2 = 90;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butKrookodile;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butKrookodile;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butKrookodile;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butKrookodile;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butKrookodile;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    
                }
                else if (ranNum == 15)
                {
                    speed2 = 306;
                    attack2 = 328;
                    health2 = 404;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butKyogre;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butKyogre;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butKyogre;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butKyogre;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butKyogre;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butKyogre;
                    }
=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butKyogre;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butKyogre;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butKyogre;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butKyogre;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butKyogre;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
       

>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a

                }
                else if (ranNum == 16)
                {
<<<<<<< HEAD
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butLucario;
                        speed2 = 90;
                        attack2 = 100;
                        health2 = 125;
                        defense2 = 90;

=======
                    speed2 = 306;
                    attack2 = 350;
                    health2 = 344;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butLucario;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butLucario;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butLucario;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butLucario;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butLucario;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butLucario;
                    }

                }
                else if (ranNum == 18)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butGarchomp;
                        speed2 = 101;
                        attack2 = 130;
                        health2 = 132;
                        defense2 = 95;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butLucario;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butLucario;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butLucario;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butLucario;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butLucario;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                   
                }
                else if (ranNum == 18)
                {
                    speed2 = 0;
                    attack2 = 0;
                    health2 = 0;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butGarchomp;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butGarchomp;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butGarchomp;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butGarchomp;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butGarchomp;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butGarchomp;
                    }

                }
                else if (ranNum == 19)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butMewtwo;
                        speed2 = 130;
                        attack2 = 110;
                        health2 = 106;
                        defense2 = 90;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butGarchomp;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butGarchomp;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butGarchomp;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butGarchomp;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butGarchomp;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                }
                else if (ranNum == 19)
                {
                    speed2 = 262;
                    attack2 = 405;
                    health2 = 364;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butMewtwo;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butMewtwo;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butMewtwo;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butMewtwo;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butMewtwo;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butMewtwo;
                    }

                }
                else if (ranNum == 20)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butPikachu;
                        speed2 = 130;
                        attack2 = 110;
                        health2 = 125;
                        defense2 = 90;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butMewtwo;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butMewtwo;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butMewtwo;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butMewtwo;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butMewtwo;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    
                }
                else if (ranNum == 20)
                {
                    speed2 = 306;
                    attack2 = 229;
                    health2 = 274;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butPikachu;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butPikachu;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butPikachu;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butPikachu;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butPikachu;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butPikachu;
                    }

                }
                else if (ranNum == 21)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butSceptile;
                        speed2 = 130;
                        attack2 = 110;
                        health2 = 106;
                        defense2 = 90;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butPikachu;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butPikachu;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butPikachu;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butPikachu;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butPikachu;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                }
                else if (ranNum == 21)
                {
                    speed2 = 372;
                    attack2 = 295;
                    health2 = 344;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butSceptile;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butSceptile;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butSceptile;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butSceptile;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butSceptile;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butSceptile;
                    }

                }
                else if (ranNum == 22)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butShedinja;
                        speed2 = 70;
                        attack2 = 90;
                        health2 = 40;
                        defense2 = 1;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butSceptile;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butSceptile;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butSceptile;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butSceptile;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butSceptile;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                }
                else if (ranNum == 22)
                {
                    speed2 = 196;
                    attack2 = 306;
                    health2 = 1;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butShedinja;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butShedinja;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butShedinja;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butShedinja;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butShedinja;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butShedinja;
                    }

                }
                else if (ranNum == 23)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butSteelix;
                        speed2 = 30;
                        attack2 = 85;
                        health2 = 95;
                        defense2 = 210;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butShedinja;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butShedinja;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butShedinja;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butShedinja;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butShedinja;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                }
                else if (ranNum == 23)
                {
                    speed2 = 251;
                    attack2 = 295;
                    health2 = 354;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butSteelix;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butSteelix;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butSteelix;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butSteelix;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butSteelix;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butSteelix;
                    }

                }
                else if (ranNum == 24)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butSylveon;
                        speed2 = 60;
                        attack2 = 65;
                        health2 = 95;
                        defense2 = 65;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butSteelix;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butSteelix;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butSteelix;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butSteelix;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butSteelix;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                  
                }
                else if (ranNum == 24)
                {
                    speed2 = 394;
                    attack2 = 251;
                    health2 = 240;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butSylveon;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butSylveon;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butSylveon;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butSylveon;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butSylveon;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butSylveon;
                    }

                }
                else if (ranNum == 25)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butTalonflame;
                        speed2 = 126;
                        attack2 = 85;
                        health2 = 85;
                        defense2 = 71;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butSylveon;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butSylveon;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butSylveon;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butSylveon;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butSylveon;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                   
                }
                else if (ranNum == 25)
                {
                    speed2 = 386;
                    attack2 = 287;
                    health2 = 360;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butTalonflame;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butTalonflame;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butTalonflame;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butTalonflame;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butTalonflame;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butTalonflame;
                    }

                }
                else if (ranNum == 26)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butToxapex;
                        speed2 = 40;
                        attack2 = 65;
                        health2 = 60;
                        defense2 = 170;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butTalonflame;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butTalonflame;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butTalonflame;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butTalonflame;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butTalonflame;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                }
                else if (ranNum == 26)
                {
                    speed2 = 386;
                    attack2 = 287;
                    health2 = 360;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butToxapex;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butToxapex;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butToxapex;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butToxapex;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butToxapex;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butToxapex;
                    }

                }
                else if (ranNum == 27)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butTyranitar;
                        speed2 = 61;
                        attack2 = 135;
                        health2 = 100;
                        defense2 = 110;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butToxapex;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butToxapex;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butToxapex;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butToxapex;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butToxapex;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }            
                }
                else if (ranNum == 27)
                {
                    speed2 = 243;
                    attack2 = 403;
                    health2 = 404;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butTyranitar;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butTyranitar;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butTyranitar;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butTyranitar;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butTyranitar;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butTyranitar;
                    }

                }
                else if (ranNum == 28)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butToxicroak;
                        speed2 = 85;
                        attack2 = 106;
                        health2 = 90;
                        defense2 = 65;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butTyranitar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butTyranitar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butTyranitar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butTyranitar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butTyranitar;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                  
                }
                else if (ranNum == 28)
                {
                    speed2 = 295;
                    attack2 = 342;
                    health2 = 370;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butToxicroak;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butToxicroak;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butToxicroak;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butToxicroak;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butToxicroak;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butToxicroak;
                    }

                }
                else if (ranNum == 29)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butVenusaur;
                        speed2 = 80;
                        attack2 = 82;
                        health2 = 90;
                        defense2 = 85;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butToxicroak;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butToxicroak;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butToxicroak;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butToxicroak;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butToxicroak;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                }
                else if (ranNum == 29)
                {
                    speed2 = 284;
                    attack2 = 289;
                    health2 = 364;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butVenusaur;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butVenusaur;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butVenusaur;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butVenusaur;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butVenusaur;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butVenusaur;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                }
                else if (ranNum == 30)
                {
                    speed2 = 203;
                    attack2 = 262;
                    health2 = 358;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butVikavolt;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke2.BackgroundImage == null)
                    {
<<<<<<< HEAD
                        team2Poke2.BackgroundImage = butVenusaur;
=======
                        team2Poke2.Image = butVikavolt;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
<<<<<<< HEAD
                        team2Poke3.BackgroundImage = butVenusaur;
=======
                        team2Poke3.Image = butVikavolt;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
<<<<<<< HEAD
                        team2Poke4.BackgroundImage = butVenusaur;
=======
                        team2Poke4.Image = butVikavolt;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
<<<<<<< HEAD
                        team2Poke5.BackgroundImage = butVenusaur;
=======
                        team2Poke5.Image = butVikavolt;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
<<<<<<< HEAD
                        team2Poke6.BackgroundImage = butVenusaur;
                    }

                }
                else if (ranNum == 30)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butVikavolt;
                        speed2 = 45;
                        attack2 = 70;
                        health2 = 82;
                        defense2 = 95;

=======
                        team2Poke6.Image = butVikavolt;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                }
                else if (ranNum == 30)
                {
                    speed2 = 328;
                    attack2 = 306;
                    health2 = 384;
                    if (team2Poke.Image == null)
                    {
                        team2Poke.Image = butZapdos;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butVikavolt;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butVikavolt;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butVikavolt;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butVikavolt;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butVikavolt;
                    }


                }
                else if (ranNum == 30)
                {
                    if (team2Poke.BackgroundImage == null)
                    {
                        team2Poke.BackgroundImage = butZapdos;
                        speed2 = 100;
                        attack2 = 90;
                        health2 = 105;
                        defense2 = 85;

=======
                    else if (team2Poke2.Image == null)
                    {
                        team2Poke2.Image = butZapdos;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
<<<<<<< HEAD
                    else if (team2Poke2.BackgroundImage == null)
                    {
                        team2Poke2.BackgroundImage = butZapdos;
                    }
                    else if (team2Poke3.BackgroundImage == null)
                    {
                        team2Poke3.BackgroundImage = butZapdos;
                    }
                    else if (team2Poke4.BackgroundImage == null)
                    {
                        team2Poke4.BackgroundImage = butZapdos;
                    }
                    else if (team2Poke5.BackgroundImage == null)
                    {
                        team2Poke5.BackgroundImage = butZapdos;
                    }
                    else if (team2Poke6.BackgroundImage == null)
                    {
                        team2Poke6.BackgroundImage = butZapdos;
                    }

=======
                    else if (team2Poke3.Image == null)
                    {
                        team2Poke3.Image = butZapdos;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke4.Image == null)
                    {
                        team2Poke4.Image = butZapdos;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke5.Image == null)
                    {
                        team2Poke5.Image = butZapdos;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
                    else if (team2Poke6.Image == null)
                    {
                        team2Poke6.Image = butZapdos;
                        CPUHealth.Maximum = health2;
                        CPUHealth.Value = health2;
                        CPUHealth.Refresh();
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                }

            }
            
            
            if (PlayerPokemon[0] == butArticuno)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Brave Bird", "Hurricane", "Ice Shard", "Frost Breath" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 85;
                attack1 = 85;
                health1 = 90;
                defense1 = 100;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;

            }
            else if (PlayerPokemon[0] == butAerodactyl)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Taunt", "Stealth Rock", "Stone Edge", "Aeiral Ace" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 130;
                attack1 = 105;
                health1 = 80;
                defense1 = 65;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butBarbaracle)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Shell Smash", "Dragon Claw", "Razor Shell", "Stone Edge" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 68;
                attack1 = 105;
                health1 = 72;
                defense1 = 115;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butBlastoise)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Water Pulse", "Aura Sphere", "Dragon Pulse", "Dark Pulse" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }

                speed1 = 78;
                attack1 = 83;
                health1 = 79;
                defense1 = 100;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butBlaziken)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Stone Edge", "Hone Claws", "Blaze Kick", "High Jump Kick" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }

                speed1 = 80;
                attack1 = 120;
                health1 = 80;
                defense1 = 70;


                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butCharizard)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Earthquake", "Dragon Claw", "Dragon Dance", "Fire Blitz" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 100;
                attack1 = 84;
                health1 = 78;
                defense1 = 78;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butDragapult)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Dragon Darts", "Dragon Dance", "Night Shade", "Shadow Ball" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 142;
                attack1 = 120;
                health1 = 88;
                defense1 = 75;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butDragonite)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Outrage", "Earthquake", "Crunch", "Stone Edge" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 80;
                attack1 = 134;
                health1 = 91;
                defense1 = 95;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butFroslass)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Shadow Claw", "Thunder Wave", "Shadow Ball", "Ice Beam" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 110;
                attack1 = 80;
                health1 = 70;
                defense1 = 100;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butGardevoir)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Psychic", "Thunderbolt", "Shadow Ball", "Misty Explosion" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 80;
                attack1 = 65;
                health1 = 103;
                defense1 = 65;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butGengar)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Shadow Ball", "Thunderbolt", "Poltergeist", "Sludge Ball" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 110;
                attack1 = 65;
                health1 = 95;
                defense1 = 60;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butGroudon)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Fire Blast", "Earthquake", "Stone Edge", "Solar Beam" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 90;
                attack1 = 150;
                health1 = 115;
                defense1 = 140;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butKrookodile)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Outrage", "Earthquake", "Crunch", "Stone Edge" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 92;
                attack1 = 117;
                health1 = 115;
                defense1 = 80;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butKyogre)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Water Spout", "Thunder", "Ice beam", "Origin Pulse" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 90;
                attack1 = 100;
                health1 = 115;
                defense1 = 90;


                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butIncineroar)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Darkest Lariat", "Earthquake", "Shadow Claw", "Flame Charge" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 60;
                attack1 = 115;
                health1 = 105;
                defense1 = 90;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butLucario)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Sword Stance", "High Jump Kick", "Shadow Claw", "Ice Punch" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 90;
                attack1 = 100;
                health1 = 125;
                defense1 = 90;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butGarchomp)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Sword Stance", "Earthquake", "Dragon Claw", "Outrage" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 101;
                attack1 = 130;
                health1 = 132;
                defense1 = 95;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butMewtwo)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Aura Sphere", "Thunder", "Shadow Ball", "Ice Beam" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 130;
                attack1 = 110;
                health1 = 106;
                defense1 = 90;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butPikachu)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Brick Break", "Thunderbolt", "Thunder Punch", "Quick Attack" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 130;
                attack1 = 110;
                health1 = 125;
                defense1 = 90;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butSceptile)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Hone Claws", "Leaf Blade", "Dynamic Punch", "Rock Slide" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 120;
                attack1 = 85;
                health1 = 95;
                defense1 = 65;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butShedinja)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Shadow Snake", "Sword Stance", "Giga Impact", "X-Scissor" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 70;
                attack1 = 90;
                health1 = 2;
                defense1 = 45;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butSteelix)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Iron Tail", "Earthquake", "Rock Slide", "Crunch" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 30;
                attack1 = 85;
                health1 = 95;
                defense1 = 210;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butSylveon)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Hypervoice", "Psyschock", "Shadow Ball", "Calm mind" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 60;
                attack1 = 65;
                health1 = 95;
                defense1 = 65;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butTalonflame)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Sword Stance", "Hurricane", "Flair Blitz", "Roost" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 126;
                attack1 = 85;
                health1 = 85;
                defense1 = 71;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butToxapex)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Gunk Shot", "Scald", "Liquidation", "Mud Slap" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 40;
                attack1 = 65;
                health1 = 60;
                defense1 = 170;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butTyranitar)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Fire Punch", "Dragon Dance", "Stone Edge", "Ice Punch" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 61;
                attack1 = 135;
                health1 = 100;
                defense1 = 110;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butToxicroak)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Acid Spray", "Gunk Shot", "Mud Slap", "Ice Punch" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 85;
                attack1 = 106;
                health1 = 90;
                defense1 = 65;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butVenusaur)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Solar Beam", "Earthquake", "Hidden Power", "Growth" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 80;
                attack1 = 82;
                health1 = 90;
                defense1 = 85;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butVikavolt)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Bug Buzz", "Thunder", "Flash Cannon", "Crunch" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 45;
                attack1 = 70;
                health1 = 82;
                defense1 = 95;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
            else if (PlayerPokemon[0] == butZapdos)
            {
                PlayerPokeAndMoves[PlayerPokemon[0]] = new List<String> { "Thunderbolt", "Thunder", "Roost", "Gunk Shot" };
                for (int j = 0; j < Move.Count; j++) { Move[j].Text = PlayerPokeAndMoves[PlayerPokemon[0]][j]; }
                speed1 = 100;
                attack1 = 90;
                health1 = 105;
                defense1 = 85;

                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
            }
        }
        //ED,MS,JM,ZL
        //JM
        private int Rockslide(int CPUHealthCur)
        {
            Random rnd = new Random();
            int ran = rnd.Next(1, 10);
            int dmg = 75;
            if (ran / 10 <= 0.1)
            {
                return 0;
            }
            else
            {
                return CPUHealthCur - dmg;
            }
        }

        private int StoneEdge(int pokeHealth)
        {
            Random rnd = new Random();
            int ran = rnd.Next(1, 5);
            int dmg = 100;
            if (ran / 5 <= .20)
            {
                return 0;
            }
            else
            {
                return pokeHealth - dmg;
            }
        }

        private int RazorShell(int PokemonHealth)
        {
            Random rnd = new Random();
            int ran = rnd.Next(1, 20);
            int dmg = 75;

            if (ran / 20 <= .20)
            {
                return 0;
            }
            else
            {
                if (PokemonHealth - dmg <= 0)
                {
                    return 0;
                }
                else
                    return PokemonHealth - dmg;
            }

        }

        private int DragonClaw(int PokemonHealth)
        {
            int dmg = 80;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int Earthquake(int PokemonHealth)
        {
            int dmg = 100;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int Crunch(int PokemonHealth)
        {
            int dmg = 80;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int WaterPulse(int PokemonHealth)
        {
            Random rnd = new Random();
            int ran = rnd.Next(1, 5);
            if (ran == 2)
            {
                int dmg = 80;
                if (PokemonHealth - dmg <= 0)
                {
                    return 0;
                }
                else
                    return PokemonHealth - dmg;
            }
            else
            {
                int dmg = 60;
                if (PokemonHealth - dmg <= 0)
                {
                    return 0;
                }
                else
                    return PokemonHealth - dmg;
            }
        }

        private int AuraSphere(int PokemonHealth)
        {
            int dmg = 80;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int DragonPulse(int PokemonHealth)
        {
            int dmg = 85;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }
        private int DarkPulse(int PokemonHealth)
        {
            int dmg = 80;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int BraveBird(int PokemonMaxHealth, int PokemonHealth)
        {
            double dmg_to_self = PokemonMaxHealth * 0.25;
            int dmg = 120;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int Hurricane(int PokemonHealth)
        {
            Random rnd = new Random();
            int ran = rnd.Next(1, 10);
            //do three numbers
            int dmg = 130;
            if (ran / 10 <= .20)
            {
                return 0;
            }
            else
            {
                if (PokemonHealth - dmg <= 0)
                {
                    return 0;
                }
                else
                    return PokemonHealth - dmg;
            }

        }

        private int IceShard(int PokemonHealth)
        {
            int dmg = 40;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int FrostBreath(int PokemonHealth)
        {
            Random rnd = new Random();
            int ran = rnd.Next(1, 10);
            int dmg = 60;
            if (ran / 10 <= .20)
            {
                return 0;
            }
            else
            {
                if (PokemonHealth - dmg <= 0)
                {
                    return 0;
                }
                else
                {
                    return PokemonHealth - dmg;
                }
            }
        }

        private int BlazeKick(int PokemonHealth)
        {
            Random rnd = new Random();
            int ran = rnd.Next(1, 10);
            int dmg = 85;
            if (ran / 10 <= .20)
            {
                return 0;
            }
            else
            {
                if (PokemonHealth - dmg <= 0)
                {
                    return 0;
                }
                else
                    return PokemonHealth - dmg;
            }
        }

        private int HighJumpKick(int PokemaxHealth, int PokemonHealth)
        {
            Random rnd = new Random();
            double dmg_to_self = PokemaxHealth * 0.25;
            int ran = rnd.Next(1, 5);
            int dmg = 85;
            if (ran / 5 <= .20)
            {
                return 0;
            }
            else
            {
                if (PokemonHealth - dmg <= 0)
                {
                    return 0;
                }
                else
                    return PokemonHealth - dmg;
            }
        }

        private int FlairBlitz(int PokemaxHealth, int PokemonHealth)
        {
            double dmg_to_self = PokemaxHealth * 0.25;
            int dmg = 120;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int DragonDarts(int PokemonHealth)
        {
            int dmg = 100;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int NightShade(int PokemonHealth)
        {
            int dmg = 50;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }
        private int ShadowBall(int PokemonHealth)
        {
            //1 in 5 def lower
            int dmg = 80;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int WaterSpout(int pokecurhealth, int pokeHPmax, int opPokeHealth)
        {
            //deals damage based on current user hp
            //(150 * hpcur) / hpmax
            int dmg = (150 * pokecurhealth) / pokeHPmax;
            if (opPokeHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return opPokeHealth - dmg;
        }

        private int Thunder(int PokemonHealth)
        {
            Random rnd = new Random();
            int ran = rnd.Next(1, 10);
            //do three numbers
            int dmg = 110;
            if (ran / 10 <= .20)
            {
                return 0;
            }
            else
            {
                if (PokemonHealth - dmg <= 0)
                {
                    return 0;
                }
                else
                    return PokemonHealth - dmg;
            }
        }

        private int IceBeam(int PokemonHealth)
        {
            int dmg = 90;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int OriginPulse(int PokemonHealth)
        {
            Random rnd = new Random();
            int ran = rnd.Next(1, 5);
            int dmg = 190;
            if (ran / 5 <= .20)
            {
                return 0;
            }
            else
            {
                if (PokemonHealth - dmg <= 0)
                {
                    return 0;
                }
                else
                    return PokemonHealth - dmg;
            }

        }

        private int AerialAce(int PokemonHealth)
        {
            int dmg = 60;

            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int StealthRock(int PokemonHealth)
        {
            int dmg = 40;

            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int BrickBreak(int PokemonHealth)
        {
            int dmg = 75;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int ThunderBolt(int PokemonHealth)
        {
            int dmg = 90;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int ThunderPunch(int PokemonHealth)
        {
            int dmg = 75;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int QuickAttack(int PokemonHealth)
        {
            int speed = 999;
            int dmg = 40;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int LeafBlade(int PokemonHealth)
        {
            int dmg = 90;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int DynamicPunch(int PokemonHealth)
        {
            //50% acc 100% confussion
            int dmg = 100;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int ShadowSneak(int PokemonHealth)
        {
            int speed = 999;
            int dmg = 40;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int XScissor(int PokemonHealth)
        {
            int dmg = 80;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int HiddenPower(int PokemonHealth)
        {
            int dmg = 60;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int FirePunch(int PokemonHealth)
        {
            int dmg = 75;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int ShadowClaw(int PokemonHealth)
        {
            int dmg = 70;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int Psychic(int PokemonHealth)
        {
            Random rdn = new Random();
            int ran = rdn.Next(1, 10);
            int dmg = 90;

            if (ran == 3)
            {
                dmg += 10;
            }

            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int MistyExplosion(int PokemonHealth)
        {
            int dmg = 100;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int Poltergeist(int PokemonHealth)
        {
            int dmg = 40;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int SludgeBall(int PokemonHealth)
        {
            int dmg = 90;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int FireBlast(int PokemonHealth)
        {
            //80% acc
            int dmg = 110;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int FlameCharge(int PokemonHealth)
        {
            //raises speed by one stage
            int dmg = 50;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int DarkestLariat(int PokemonHealth)
        {
            int dmg = 85;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int IcePunch(int PokemonHealth)
        {
            int dmg = 75;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int HyperVoice(int PokemonHealth)
        {
            int dmg = 90;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int IronTail(int PokemonHealth)
        {
            //30% chance of lowering def by one stage by lower 70%acc
            int dmg = 100;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int PsyShock(int PokemonHealth)
        {
            int dmg = 80;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int GunkShot(int PokemonHealth)
        {
            //80% acc
            int dmg = 120;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int Scald(int PokemonHealth)
        {
            int dmg = 80;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int Liquidation(int PokemonHealth)
        {
            int dmg = 85;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int MudSlap(int PokemonHealth)
        {
            int dmg = 20;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int BugBuzz(int PokemonHealth)
        {
            //10% lowering targ def by one stage
            int dmg = 90;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int FlashCannon(int PokemonHealth)
        {
            //10% lowering targ def by one stage
            int dmg = 80;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int Taunt(int PokemonHealth)
        {
            int dmg = 20;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int Outrage(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int SwordsDance(int PokemonHealth)
        {
            int dmg = 20;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int HoneClaws(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }
        private int AcidSpray(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int SolarBeam(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int DragonDance(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int ThunderWave(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int SwordStance(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int GigaImpact(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int Roost(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int FireBlitz(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int CalmMind(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }
        private int Growth(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }

        private int ShellSmash(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }
        private int ShadowSnake(int PokemonHealth)
        {
            int dmg = 200;
            if (PokemonHealth - dmg <= 0)
            {
                return 0;
            }
            else
                return PokemonHealth - dmg;
        }
        //JM


        //MS
        private void Move1_Click(object sender, EventArgs e)
        {
            whoTurn = false;
            if (whoTurn == false)
            {
                if (Move1.Text == "Water Pulse")
                {
                    CPUHealth.Value = WaterPulse(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "BraveBird")
                {
                    CPUHealth.Value = BraveBird(PlayerHealth.Maximum, CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Taunt")
                {
                    CPUHealth.Value = Taunt(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Shell Smash")
                {
                    CPUHealth.Value = (CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Stone Edge")
                {
                    CPUHealth.Value = StoneEdge(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Earthquake")
                {
                    CPUHealth.Value = Earthquake(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Dragon Darts")
                {
                    CPUHealth.Value = DragonDarts(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Outrage")
                {
                    CPUHealth.Value = Outrage(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Shadow Claw")
                {
                    CPUHealth.Value = ShadowClaw(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Psychic")
                {
                    CPUHealth.Value = Psychic(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Shadow Ball")
                {
                    CPUHealth.Value = ShadowBall(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Fire Blast")
                {
                    CPUHealth.Value = FireBlast(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Water Spout")
                {
                    CPUHealth.Value = WaterSpout(PlayerHealth.Value, PlayerHealth.Maximum, CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Swords Dance")
                {
                    CPUHealth.Value = SwordsDance(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Aura Sphere")
                {
                    CPUHealth.Value = AuraSphere(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Brick Break")
                {
                    CPUHealth.Value = BrickBreak(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Hone Claws")
                {
                    CPUHealth.Value = HoneClaws(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Shadow Sneak")
                {
                    CPUHealth.Value = ShadowSneak(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Iron Tail")
                {
                    CPUHealth.Value = IronTail(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Hypervoice")
                {
                    CPUHealth.Value = HyperVoice(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Gunk Shot")
                {
                    CPUHealth.Value = GunkShot(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Fire Punch")
                {
                    CPUHealth.Value = FirePunch(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Acid Spray")
                {
                    CPUHealth.Value = AcidSpray(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Solar Beam")
                {
                    CPUHealth.Value = SolarBeam(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Bug Buzz")
                {
                    CPUHealth.Value = BugBuzz(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move1.Text == "Thunderbolt")
                {
                    CPUHealth.Value = ThunderBolt(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                whoTurn = true;
                team2Turn(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
            }
        }
        //MS
        //EC
        private void Move2_Click(object sender, EventArgs e)
        {
            whoTurn = false;
            if (whoTurn == false)
            {
                if (Move2.Text == "Hurricane")
                {
                    CPUHealth.Value = Hurricane(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Stealth Rock")
                {
                    CPUHealth.Value = StealthRock(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Dragon Claw")
                {
                    CPUHealth.Value = DragonClaw(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Aura Sphere")
                {
                    CPUHealth.Value = AuraSphere(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Hone Claws")
                {
                    CPUHealth.Value = HoneClaws(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Dragon Dance")
                {
                    CPUHealth.Value = DragonDance(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Thunder Wave")
                {
                    CPUHealth.Value = ThunderWave(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Thunderbolt")
                {
                    CPUHealth.Value = ThunderBolt(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Thunder")
                {
                    CPUHealth.Value = Thunder(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Leaf Blade")
                {
                    CPUHealth.Value = LeafBlade(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "High Jump Kick")
                {
                    CPUHealth.Value = HighJumpKick(PlayerHealth.Maximum, CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Sword Stance")
                {
                    CPUHealth.Value = SwordStance(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Psyshock")
                {
                    CPUHealth.Value = PsyShock(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Scald")
                {
                    CPUHealth.Value = Scald(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move2.Text == "Gunk Shot")
                {
                    CPUHealth.Value = GunkShot(CPUHealth.Value);
                    if (CPUHealth.Value == CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke5.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                whoTurn = true;
                team2Turn(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
            }

        }

        private void Move3_Click(object sender, EventArgs e)
        {
            whoTurn = false;
            if (whoTurn == false)
            {
                if (Move3.Text == "Rock Slide")
                {
                    CPUHealth.Value = Rockslide(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Ice Shard")
                {
                    CPUHealth.Value = IceShard(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Stone Edge")
                {
                    CPUHealth.Value = StoneEdge(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Razor Shell")
                {
                    CPUHealth.Value = RazorShell(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Dragon Pulse")
                {
                    CPUHealth.Value = DragonPulse(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Blaze Kick")
                {
                    CPUHealth.Value = BlazeKick(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Dragon Dance")
                {
                    CPUHealth.Value = DragonDarts(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Night Shade")
                {
                    CPUHealth.Value = NightShade(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Crunch")
                {
                    CPUHealth.Value = Crunch(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Shadow Ball")
                {
                    CPUHealth.Value = ShadowBall(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Poltergeist")
                {
                    CPUHealth.Value = Poltergeist(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Ice beam")
                {
                    CPUHealth.Value = IceBeam(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Shadow Claw")
                {
                    CPUHealth.Value = ShadowClaw(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Thunder Punch")
                {
                    CPUHealth.Value = ThunderPunch(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Dynamic Punch")
                {
                    CPUHealth.Value = DynamicPunch(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Giga Impact")
                {
                    CPUHealth.Value = GigaImpact(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Flair Blitz")
                {
                    CPUHealth.Value = FlairBlitz(PlayerHealth.Maximum, CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Liquidation")
                {
                    CPUHealth.Value = Liquidation(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Mud Slap")
                {
                    CPUHealth.Value = MudSlap(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Hidden Power")
                {
                    CPUHealth.Value = HiddenPower(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Flash Cannon")
                {
                    CPUHealth.Value = FlashCannon(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move3.Text == "Roost")
                {
                    CPUHealth.Value = Roost(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                whoTurn = true;
                team2Turn(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
            }

        }
        //ED

        //ZL
        private void DetectTeam1PokeImage(Image butCharizard, Image butBlaziken, Image butBlastoise, Image butBarbaracle, Image butIncineroar, Image butAerodactyl, Image butArticuno, Image butDragapult, Image butDragonite, Image butFroslass, Image butGardevoir, Image butGengar, Image butGroudon, Image butKrookodile, Image butKyogre, Image butLucario, Image butGarchomp, Image butMewtwo, Image butPikachu, Image butSceptile, Image butShedinja, Image butSteelix, Image butSylveon, Image butTalonflame, Image butToxapex, Image butToxicroak, Image butTyranitar, Image butVenusaur, Image butVikavolt, Image butZapdos)
        {

            if (team1Poke.BackgroundImage == imgArticuno)
            {
                speed1 = 85;
                attack1 = 85;
                health1 = 90;
                defense1 = 100;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgAerodactyl)
            {
                speed1 = 130;
                attack1 = 105;
                health1 = 80;
                defense2 = 65;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgBarbaracle)
            {
                attack1 = 105;
                health1 = 72;
                defense1 = 115;
                speed2 = 68;
                CPUHealth.Maximum = health1;
                CPUHealth.Value = health1;
                CPUHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgBlastoise)
            {
                speed1 = 78;
                attack1 = 83;
                health1 = 79;
                defense1 = 100;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgBlaziken)
            {
                speed1 = 80;
                attack1 = 110;
                health1 = 80;
                defense1 = 70;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();

            }
            else if (team1Poke.BackgroundImage == imgCharizard)
            {
                speed1 = 100;
                attack1 = 84;
                health1 = 78;
                defense2 = 78;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();

            }
            else if (team1Poke.BackgroundImage == imgDragapult)
            {
                speed1 = 142;
                attack1 = 120;
                health1 = 88;
                defense1 = 75;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }

            else if (team1Poke.BackgroundImage == imgFroslass)
            {
                speed1 = 110;
                attack1 = 80;
                health1 = 70;
                defense1 = 100;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();

            }

            else if (team1Poke.BackgroundImage == imgGardevoir)
            {
                speed1 = 80;
                attack1 = 65;
                health1 = 70;
                defense1 = 65;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();

            }
            else if (team1Poke.BackgroundImage == imgGengar)
            {
                speed1 = 90;
                attack1 = 150;
                health1 = 105;
                defense1 = 140;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();

            }
            else if (team1Poke.BackgroundImage == imgGroudon)
            {
                speed1 = 90;
                attack1 = 150;
                health1 = 115;
                defense2 = 140;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgGengar)
            {
                speed1 = 220;
                attack1 = 65;
                health1 = 95;
                defense1 = 60;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();

            }
            else if (team1Poke.BackgroundImage == imgKrookodile)
            {
                speed1 = 92;
                attack1 = 117;
                health1 = 115;
                defense1 = 80;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();

            }
            else if (team1Poke.BackgroundImage == imgKyogre)
            {
                speed1 = 90;
                attack1 = 100;
                health1 = 125;
                defense1 = 90;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();

            }
            else if (team1Poke.BackgroundImage == imgIncineroar)
            {
                speed1 = 60;
                attack1 = 115;
                health1 = 105;
                defense1 = 90;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();

            }
            else if (team1Poke.BackgroundImage == imgLucario)
            {
                speed1 = 90;
                attack1 = 100;
                health1 = 115;
                defense1 = 90;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();

            }
            else if (team1Poke.BackgroundImage == imgMewtwo)
            {

                speed1 = 130;
                attack1 = 110;
                health1 = 106;
                defense1 = 90;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();

            }
            else if (team1Poke.BackgroundImage == imgGarchomp)
            {
                speed1 = 101;
                attack1 = 130;
                health1 = 132;
                defense1 = 95;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();



            }
            else if (team1Poke.BackgroundImage == imgPikachu)
            {

                speed1 = 130;
                attack1 = 120;
                health1 = 125;
                defense1 = 90;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgSceptile)
            {
                speed1 = 110;
                attack1 = 85;
                health1 = 95;
                defense1 = 65;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();

            }
            else if (team1Poke.BackgroundImage == imgShedinja)
            {
                speed1 = 70;
                attack1 = 90;
                health1 = 40;
                defense1 = 2;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgSteelix)
            {
                speed1 = 30;
                attack1 = 85;
                health1 = 95;
                defense1 = 210;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgSylveon)
            {
                speed1 = 60;
                attack1 = 65;
                health1 = 95;
                defense1 = 65;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgTalonflame)
            {
                speed1 = 126;
                attack1 = 85;
                health1 = 85;
                defense1 = 72;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgToxapex)
            {
                speed1 = 40;
                attack1 = 65;
                health1 = 60;
                defense1 = 170;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgTyranitar)
            {
                speed1 = 62;
                attack1 = 135;
                health1 = 100;
                defense1 = 120;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgToxicroak)
            {
                speed1 = 85;
                attack1 = 106;
                health1 = 90;
                defense1 = 65;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgVenusaur)
            {
                speed1 = 80;
                attack1 = 82;
                health1 = 90;
                defense1 = 85;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgVikavolt)
            {
                speed1 = 45;
                attack1 = 70;
                health1 = 82;
                defense1 = 95;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
            else if (team1Poke.BackgroundImage == imgZapdos)
            {
                speed1 = 100;
                attack1 = 90;
                health1 = 105;
                defense1 = 85;
                PlayerHealth.Maximum = health1;
                PlayerHealth.Value = health1;
                PlayerHealth.Refresh();
            }
        }
        //ZL
        //JM
        private void DetectTeam2PokeImage(Image butCharizard, Image butBlaziken, Image butBlastoise, Image butBarbaracle, Image butIncineroar, Image butAerodactyl, Image butArticuno, Image butDragapult, Image butDragonite, Image butFroslass, Image butGardevoir, Image butGengar, Image butGroudon, Image butKrookodile, Image butKyogre, Image butLucario, Image butGarchomp, Image butMewtwo, Image butPikachu, Image butSceptile, Image butShedinja, Image butSteelix, Image butSylveon, Image butTalonflame, Image butToxapex, Image butToxicroak, Image butTyranitar, Image butVenusaur, Image butVikavolt, Image butZapdos)
        {

            if (team2Poke.BackgroundImage == imgArticuno)
            {
                speed2 = 85;
                attack2 = 85;
                health2 = 90;
                defense2 = 100;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgAerodactyl)
            {
                speed2 = 130;
                attack2 = 105;
                health2 = 80;
                defense2 = 65;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgBarbaracle)
            {
                attack2 = 105;
                health2 = 72;
                defense2 = 115;
                speed2 = 68;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgBlastoise)
            {
                speed2 = 78;
                attack2 = 83;
                health2 = 79;
                defense2 = 100;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgBlaziken)
            {
                speed2 = 80;
                attack2 = 110;
                health2 = 80;
                defense2 = 70;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();

            }
            else if (team2Poke.BackgroundImage == imgCharizard)
            {
                speed2 = 100;
                attack2 = 84;
                health2 = 78;
                defense2 = 78;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();

            }
            else if (team2Poke.BackgroundImage == imgDragapult)
            {
                speed2 = 142;
                attack2 = 120;
                health2 = 88;
                defense2 = 75;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }

            else if (team2Poke.BackgroundImage == imgFroslass)
            {
                speed2 = 110;
                attack2 = 80;
                health2 = 70;
                defense2 = 100;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();

            }

            else if (team2Poke.BackgroundImage == imgGardevoir)
            {
                speed2 = 80;
                attack2 = 65;
                health2 = 70;
                defense2 = 65;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();

            }
            else if (team2Poke.BackgroundImage == imgGengar)
            {
                speed2 = 90;
                attack2 = 150;
                health2 = 105;
                defense2 = 140;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();

            }
            else if (team2Poke.BackgroundImage == imgGroudon)
            {
                speed2 = 90;
                attack2 = 150;
                health2 = 115;
                defense2 = 140;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgGengar)
            {
                speed2 = 220;
                attack2 = 65;
                health2 = 95;
                defense2 = 60;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();

            }
            else if (team2Poke.BackgroundImage == imgKrookodile)
            {
                speed2 = 92;
                attack2 = 117;
                health2 = 115;
                defense2 = 80;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();

            }
            else if (team2Poke.BackgroundImage == imgKyogre)
            {
                speed2 = 90;
                attack2 = 100;
                health2 = 125;
                defense2 = 90;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();

            }
            else if (team2Poke.BackgroundImage == imgIncineroar)
            {
                speed2 = 60;
                attack2 = 115;
                health2 = 105;
                defense2 = 90;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();

            }
            else if (team2Poke.BackgroundImage == imgLucario)
            {
                speed2 = 90;
                attack2 = 100;
                health2 = 115;
                defense2 = 90;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();

            }
            else if (team2Poke.BackgroundImage == imgMewtwo)
            {

                speed2 = 130;
                attack2 = 110;
                health2 = 106;
                defense2 = 90;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();

            }
            else if (team2Poke.BackgroundImage == imgGarchomp)
            {
                speed2 = 101;
                attack2 = 130;
                health2 = 132;
                defense2 = 95;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();



            }
            else if (team2Poke.BackgroundImage == imgPikachu)
            {

                speed2 = 130;
                attack2 = 120;
                health2 = 125;
                defense2 = 90;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgSceptile)
            {
                speed2 = 110;
                attack2 = 85;
                health2 = 95;
                defense2 = 65;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();

            }
            else if (team2Poke.BackgroundImage == imgShedinja)
            {
                speed2 = 70;
                attack2 = 90;
                health2 = 40;
                defense2 = 2;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgSteelix)
            {
                speed2 = 30;
                attack2 = 85;
                health2 = 95;
                defense2 = 210;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgSylveon)
            {
                speed2 = 60;
                attack2 = 65;
                health2 = 95;
                defense2 = 65;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgTalonflame)
            {
                speed2 = 126;
                attack2 = 85;
                health2 = 85;
                defense2 = 72;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgToxapex)
            {
                speed2 = 40;
                attack2 = 65;
                health2 = 60;
                defense2 = 170;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgTyranitar)
            {
                speed2 = 62;
                attack2 = 135;
                health2 = 100;
                defense2 = 120;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgToxicroak)
            {
                speed2 = 85;
                attack2 = 106;
                health2 = 90;
                defense2 = 65;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgVenusaur)
            {
                speed2 = 80;
                attack2 = 82;
                health2 = 90;
                defense2 = 85;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgVikavolt)
            {
                speed2 = 45;
                attack2 = 70;
                health2 = 82;
                defense2 = 95;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
            else if (team2Poke.BackgroundImage == imgZapdos)
            {
                speed2 = 100;
                attack2 = 90;
                health2 = 105;
                defense2 = 85;
                CPUHealth.Maximum = health2;
                CPUHealth.Value = health2;
                CPUHealth.Refresh();
            }
        }
        //JM

        //MS
        private void Move4_Click(object sender, EventArgs e)
        {
            whoTurn = false;
            if (whoTurn == false)
            {
                if (Move4.Text == "Frost Breath")
                {
                    CPUHealth.Value = FrostBreath(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Aeiral Ace")
                {
                    CPUHealth.Value = AerialAce(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Stone Edge")
                {
                    CPUHealth.Value = StoneEdge(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Dark Pulse")
                {
                    CPUHealth.Value = DarkPulse(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "High Jump Kick")
                {
                    CPUHealth.Value = HighJumpKick(PlayerHealth.Maximum, CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Fire Blitz")
                {
                    CPUHealth.Value = FireBlitz(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Shadow Ball")
                {
                    CPUHealth.Value = ShadowBall(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Ice Beam")
                {
                    CPUHealth.Value = IceBeam(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Misty Explosion")
                {
                    CPUHealth.Value = MistyExplosion(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Sludge Ball")
                {
                    CPUHealth.Value = SludgeBall(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Solar Beam")
                {
                    CPUHealth.Value = SolarBeam(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Origin Pulse")
                {
                    CPUHealth.Value = OriginPulse(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Ice Punch")
                {
                    CPUHealth.Value = IcePunch(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Outrage")
                {
                    CPUHealth.Value = Outrage(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Quick Attack")
                {
                    CPUHealth.Value = QuickAttack(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Rock Slide")
                {
                    CPUHealth.Value = Rockslide(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "X-Scissor")
                {
                    CPUHealth.Value = XScissor(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Crunch")
                {
                    CPUHealth.Value = Crunch(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Calm mind")
                {
                    CPUHealth.Value = CalmMind(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Roost")
                {
                    CPUHealth.Value = Roost(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Growth")
                {
                    CPUHealth.Value = Growth(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (Move4.Text == "Gunk Shot")
                {
                    CPUHealth.Value = GunkShot(CPUHealth.Value);
                    if (CPUHealth.Value <= CPUHealth.Minimum)
                    {
                        team2Poke.BackgroundImage = team2Poke2.BackgroundImage;
                        team2Poke2.BackgroundImage = team2Poke3.BackgroundImage;
                        team2Poke3.BackgroundImage = team2Poke4.BackgroundImage;
                        team2Poke4.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke5.BackgroundImage = team2Poke6.BackgroundImage;
                        team2Poke6.BackgroundImage = team2Poke7.BackgroundImage;
                        DetectTeam2PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                whoTurn = true;
                team2Turn(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
            }

            //MS

        }


        /*This function will be the cpu's moves*/
        //EC
        public void team2Turn(Image butCharizard, Image butBlaziken, Image butBlastoise, Image butBarbaracle, Image butIncineroar, Image butAerodactyl, Image butArticuno, Image butDragapult, Image butDragonite, Image butFroslass, Image butGardevoir, Image butGengar, Image butGroudon, Image butKrookodile, Image butKyogre, Image butLucario, Image butGarchomp, Image butMewtwo, Image butPikachu, Image butSceptile, Image butShedinja, Image butSteelix, Image butSylveon, Image butTalonflame, Image butToxapex, Image butToxicroak, Image butTyranitar, Image butVenusaur, Image butVikavolt, Image butZapdos)
        {
            String move;
            int selectMove;


            if (CPUpokemon[0].BackgroundImage == butAerodactyl)
            {

                List<string> moves = new List<string> { "Taunt", "Stealth Rock", "Stone Edge", "Aeiral Ace" };
                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Taunt")
                {
                    PlayerHealth.Value = Taunt(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Taunt(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;

>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Stealth Rock")
                {
                    PlayerHealth.Value = StealthRock(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Stone Edge")
                {
                    PlayerHealth.Value = StoneEdge(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Aeiral Ace")
                {
                    PlayerHealth.Value = AerialAce(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butArticuno)
            {

                List<string> moves = new List<string> { "Brave Bird", "Hurricane", "Ice Shard", "Frost Breath" };
                Random ran = new Random();
                selectMove = ran.Next(0, 4);


                move = moves[selectMove];

                if (move == "Brave Bird")
                {
                    PlayerHealth.Value = BraveBird(CPUHealth.Maximum, PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);

=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Hurricane")
                {
                    PlayerHealth.Value = Hurricane(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Ice Shard")
                {
                    PlayerHealth.Value = IceShard(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Frost Breath")
                {
                    PlayerHealth.Value = FrostBreath(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butBarbaracle)
            {

                List<string> moves = new List<string> { "Shell Smash", "Dragon Claw", "Razor Shell", "Stone Edge" };
                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Shell Smash")
                {
                    PlayerHealth.Value = ShellSmash(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Dragon Claw")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = DragonClaw(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = DragonClaw(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Razor Shell")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = RazorShell(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = RazorShell(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Stone Edge")
                {
                    PlayerHealth.Value = StoneEdge(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butBlastoise)
            {
                List<string> moves = new List<string> { "Water Pulse", "Aura Sphere", "Dragon Pulse", "Dark Pulse" };
                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Water Pulse")
                {
                    PlayerHealth.Value = WaterPulse(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (move == "Aura Sphere")
                {
                    PlayerHealth.Value = AuraSphere(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }     
                }
                else if (move == "Aura Sphere")
                {
                        PlayerHealth.Value = AuraSphere(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Dragon Pulse")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = DragonPulse(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = DragonPulse(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Dark Pulse")
                {
                    PlayerHealth.Value = DarkPulse(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }
            //EC
            //ZL
            else if (CPUpokemon[0].BackgroundImage == butBlaziken)
            {

                List<string> moves = new List<string> { "Stone Edge", "Hone Claws", "Blaze Kick", "High Jump Kick" };
                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Stone Edge")
                {
                    PlayerHealth.Value = StoneEdge(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Hone Claws")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = HoneClaws(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = HoneClaws(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Blaze Kick")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = BlazeKick(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = BlazeKick(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "High Jump Kick")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = HighJumpKick(CPUHealth.Maximum, PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = HighJumpKick(CPUHealth.Maximum, PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butCharizard)
            {

                List<string> moves = new List<string> { "Earthquake", "Dragon Claw", "Dragon Dance", "Fire Blitz" };
                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Earthquake")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Dragon Claw")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = DragonClaw(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = DragonClaw(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Dragon Dance")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = DragonDarts(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = DragonDarts(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Fire Blitz")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = FireBlitz(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = FireBlitz(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }
            //ZL
            //JM
            else if (CPUpokemon[0].BackgroundImage == butDragapult)
            {

                List<string> moves = new List<string> { "Dragon Darts", "Dragon Dance", "Night Shade", "Shadow Ball" };


                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Dragon Darts")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = DragonDarts(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (move == "Dragon Dance")
                {
                    PlayerHealth.Value = DragonDance(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {

                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = DragonDarts(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
                       
                        
                }
                else if (move == "Dragon Dance")
                {
                        PlayerHealth.Value = DragonDance(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;

                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Night Shade")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = NightShade(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);

=======
                        PlayerHealth.Value = NightShade(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Shadow Ball")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ShadowBall(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ShadowBall(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butDragonite)
            {

                List<string> moves = new List<string> { "Dragon Dance", "Roost", "Dragon Claw", "Fire Punch" };


                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Dragon Dance")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = DragonDance(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = DragonDance(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Roost")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Roost(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Roost(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Dragon Claw")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = DragonClaw(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = DragonClaw(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Fire Punch")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = FirePunch(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = FirePunch(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }
            //JM


            //MS

            else if (CPUpokemon[0].BackgroundImage == butFroslass)
            {

                List<string> moves = new List<string> { "Shadow Claw", "Thunder Wave", "Shadow Ball", "Ice Beam" };


                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Shadow Claw")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ShadowClaw(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ShadowClaw(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Thunder Wave")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ThunderWave(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ThunderWave(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Shadow Ball")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ShadowBall(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ShadowBall(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Ice Beam")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = IceBeam(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = IceBeam(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = PlayerPokemon[1];
                        team1Poke2.Image = PlayerPokemon[2];
                        team1Poke3.Image = PlayerPokemon[3];
                        team1Poke4.Image = PlayerPokemon[4];
                        team1Poke5.Image = PlayerPokemon[5];
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butGarchomp)
            {

                List<string> moves = new List<string> { "Sword Stance", "Earthquake", "Dragon Claw", "Outrage" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Sword Stance")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = SwordStance(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = SwordStance(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Earthquake")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Dragon Claw")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = DragonClaw(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = DragonClaw(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Outrage")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Outrage(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Outrage(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butGardevoir)
            {

                List<string> moves = new List<string> { "Psychic", "Thunderboly", "Shadow Ball", "Misty Explosion" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Psychic")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Psychic(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Psychic(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Thunderbolt")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ThunderBolt(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ThunderBolt(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Shadow Ball")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ShadowBall(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ShadowBall(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Misty Explosion")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = MistyExplosion(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = MistyExplosion(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }
            //MS

            //JM

            else if (CPUpokemon[0].BackgroundImage == butGengar)
            {

                List<string> moves = new List<string> { "Shadow Ball", "Thunderbolt", "Poltergeist", "Sludge Ball" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Shadow Ball")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ShadowBall(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ShadowBall(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Thunderbolt")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ThunderBolt(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ThunderBolt(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Poltergeist")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Poltergeist(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (move == "Sludge Ball")
                {
                    PlayerHealth.Value = SludgeBall(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Poltergeist(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
                    
                 }
                else if (move == "Sludge Ball")
                {
                        PlayerHealth.Value = SludgeBall(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butGroudon)
            {

                List<string> moves = new List<string> { "Fire Blast", "Earthquake", "Stone Edge", "Solar Beam" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Fire Blast")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = FireBlast(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = FireBlast(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Earthquake")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Stone Edge")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = StoneEdge(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = StoneEdge(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Solar Beam")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = SolarBeam(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = SolarBeam(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }
            //JM

            //ZL
            else if (CPUpokemon[0].BackgroundImage == butIncineroar)
            {

                List<string> moves = new List<string> { "Darkest Lariat", "Flame Charge", "Earthquake", "Sword Stance" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Darkest Lariat")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = DarkestLariat(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = DarkestLariat(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Flame Charge")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = FlameCharge(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
                    }
                }
                else if (move == "Earthquake")
                {
                    PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                    
                    PlayerHealth.Value = FlameCharge(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                        }
                }
                else if (move == "Earthquake")
                {
                    
                    PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Sword Stance")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = SwordStance(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                    
                    PlayerHealth.Value = SwordStance(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butKrookodile)
            {

                List<string> moves = new List<string> { "Outrage", "Earthquake", "Crunch", "Stone Edge" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Outrage")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Outrage(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                    
                    PlayerHealth.Value = Outrage(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                //ZL

                //EC
                else if (move == "Earthquake")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                    
                    PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        PlayerPokemon.RemoveAt(0);
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Crunch")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Crunch(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                    
                    PlayerHealth.Value = Crunch(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Stone Edge")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = StoneEdge(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                    
                    PlayerHealth.Value = StoneEdge(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butKyogre)
            {

                List<string> moves = new List<string> { "Water Spout", "Thunder", "Ice beam", "Origin Pulse" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Water Spout")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = WaterSpout(CPUHealth.Value, CPUHealth.Maximum, PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                    
                    PlayerHealth.Value = WaterSpout(CPUHealth.Value, CPUHealth.Maximum,PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Thunder")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Thunder(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                    
                    PlayerHealth.Value = Thunder(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Ice beam")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = IceBeam(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = IceBeam(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Origin Pulse")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = OriginPulse(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = OriginPulse(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butLucario)
            {

                List<string> moves = new List<string> { "Sword Stance", "High Jump Kick", "Shadow Claw", "Ice Punch" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Sword Stance")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = SwordStance(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = SwordStance(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "High Jump Kick")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = HighJumpKick(CPUHealth.Maximum, PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = HighJumpKick(CPUHealth.Maximum, PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Shadow Claw")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ShadowClaw(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ShadowClaw(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Ice Punch")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = IcePunch(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = IcePunch(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butMewtwo)
            {

                List<string> moves = new List<string> { "Aura Sphere", "Thunder", "Shadow Ball", "Ice Beam" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Aura Sphere")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = AuraSphere(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = AuraSphere(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Thunder")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Thunder(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Thunder(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        PlayerPokemon.RemoveAt(0);
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Shadow Ball")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ShadowBall(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ShadowBall(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Ice Beam")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = IceBeam(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = IceBeam(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butPikachu)
            {

                List<string> moves = new List<string> { "Brick Break", "Thunderbolt", "Thunder Punch", "Quick Attack" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Brick Break")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = BrickBreak(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = BrickBreak(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Thunderbolt")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ThunderBolt(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ThunderBolt(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Thunder Punch")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ThunderPunch(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ThunderPunch(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Quick Attack")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = QuickAttack(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = QuickAttack(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butSceptile)
            {

                List<string> moves = new List<string> { "Hone Claws", "Leaf Blade", "Dynamic Punch", "Rock Slide" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Hone Claws")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = HoneClaws(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = HoneClaws(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Leaf Blade")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = LeafBlade(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = LeafBlade(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        PlayerPokemon.RemoveAt(0);
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Dynamic Punch")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = DynamicPunch(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = DynamicPunch(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Rock Slide")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Rockslide(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Rockslide(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butShedinja)
            {

                List<string> moves = new List<string> { "Shadow Snake", "Sword Stance", "Giga Impact", "X-Scissor" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Shadow Snake")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ShadowSnake(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ShadowSnake(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Sword Stance")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = SwordStance(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = SwordStance(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Giga Impact")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = GigaImpact(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = GigaImpact(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "X-Scissor")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = XScissor(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = XScissor(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }
            //EC
            //MS
            else if (CPUpokemon[0].BackgroundImage == butSteelix)
            {

                List<string> moves = new List<string> { "Iron Tail", "Earthquake", "Rock Slide", "Crunch" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Iron Tail")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = IronTail(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = IronTail(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Earthquake")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Rock Slide")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Rockslide(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Rockslide(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Crunch")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Crunch(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Crunch(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butSylveon)
            {

                List<string> moves = new List<string> { "Hypervoice", "Psyschock", "Shadow Ball", "Calm Mind" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Hypervoice")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = HyperVoice(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = HyperVoice(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Psyschock")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = PsyShock(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = PsyShock(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Shadow Ball")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ShadowBall(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ShadowBall(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Calm Mind")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = CalmMind(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = CalmMind(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butTalonflame)
            {

                List<string> moves = new List<string> { "Sword Stance", "Hurricane", "Flair Blitz", "Roost" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Sword Stance")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = SwordStance(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = SwordStance(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Hurricane")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Hurricane(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Hurricane(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Flair Blitz")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = FlairBlitz(CPUHealth.Maximum, PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = FlairBlitz(CPUHealth.Maximum, PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Roost")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Roost(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Roost(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butToxapex)
            {

                List<string> moves = new List<string> { "Gunk Shot", "Scald", "Liquidation", "Mud Slap" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Gunk Shot")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = GunkShot(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = GunkShot(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Scald")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Scald(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Scald(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Liquidation")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Liquidation(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Liquidation(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }

                }
                else if (move == "Mud Slap")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = MudSlap(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = MudSlap(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }
            //MS
            //ZL
            else if (CPUpokemon[0].BackgroundImage == butToxicroak)
            {

                List<string> moves = new List<string> { "Acid Spray", "Gunk Shot", "Mud Slap", "Ice Punch" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Acid Spray")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = AcidSpray(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = AcidSpray(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Gunk Shot")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = GunkShot(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = GunkShot(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Mud Slap")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = MudSlap(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = MudSlap(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Ice Punch")
                {
                    PlayerHealth.Value = IcePunch(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
<<<<<<< HEAD
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butTyranitar)
            {

                List<string> moves = new List<string> { "Fire Punch", "Dragon Dance", "Stone Edge", "Ice Punch" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Fire Punch")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = FirePunch(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = FirePunch(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Dragon Dance")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = DragonDance(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = DragonDance(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Stone Edge")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = StoneEdge(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = StoneEdge(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Ice Punch")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = IcePunch(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = IcePunch(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butVenusaur)
            {

                List<string> moves = new List<string> { "Solar Beam", "Earthquake", "Hidden Power", "Growth" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Solar Beam")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = SolarBeam(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = SolarBeam(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Earthquake")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Earthquake(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Hidden Power")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = HiddenPower(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = HiddenPower(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Growth")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Growth(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Growth(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butVikavolt)
            {

                List<string> moves = new List<string> { "Bug Buzz", "Thunder", "Flash Cannon", "Crunch" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Bug Buzz")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = BugBuzz(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = BugBuzz(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Thunder")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Thunder(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Thunder(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Flash Cannon")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = FlashCannon(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = FlashCannon(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Crunch")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Crunch(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Crunch(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }

            else if (CPUpokemon[0].BackgroundImage == butZapdos)
            {

                List<string> moves = new List<string> { "Thunderbolt", "Thunder", "Roost", "Gunk Shot" };



                Random ran = new Random();
                selectMove = ran.Next(0, 4);

                move = moves[selectMove];

                if (move == "Thunderbolt")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = ThunderBolt(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = ThunderBolt(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Thunder")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Thunder(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Thunder(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Roost")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = Roost(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = Roost(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                else if (move == "Gunk Shot")
                {
<<<<<<< HEAD
                    PlayerHealth.Value = GunkShot(PlayerHealth.Value);
                    if (PlayerHealth.Value <= PlayerHealth.Minimum)
                    {
                        team1Poke.BackgroundImage = team1Poke2.BackgroundImage;
                        team1Poke2.BackgroundImage = team1Poke3.BackgroundImage;
                        team1Poke3.BackgroundImage = team1Poke4.BackgroundImage;
                        team1Poke4.BackgroundImage = team1Poke5.BackgroundImage;
                        team1Poke5.BackgroundImage = team1Poke6.BackgroundImage;
                        team1Poke6.BackgroundImage = team1Poke7.BackgroundImage;
                        DetectTeam1PokeImage(imgCharizard, imgBlaziken, imgBlastoise, imgBarbaracle, imgIncineroar, imgAerodactyl, imgArticuno, imgDragapult, imgDragonite, imgFroslass, imgGardevoir, imgGengar, imgGroudon, imgKrookodile, imgKyogre, imgLucario, imgGarchomp, imgMewtwo, imgPikachu, imgSceptile, imgShedinja, imgSteelix, imgSylveon, imgTalonflame, imgToxapex, imgToxicroak, imgTyranitar, imgVenusaur, imgVikavolt, imgZapdos);
=======
                        PlayerHealth.Value = GunkShot(PlayerHealth.Value);
                        if (PlayerHealth.Value <= PlayerHealth.Minimum)
                        {
                        team1Poke.Image = team1Poke2.Image;
                        team1Poke2.Image = team1Poke3.Image;
                        team1Poke3.Image = team1Poke4.Image;
                        team1Poke4.Image = team1Poke5.Image;
                        team1Poke5.Image = team1Poke6.Image;
                        team1Poke6.Image = team1Poke7.Image;
                    }
>>>>>>> 7a4fbcb0ba8fb5292688d6c2c12cff981f1bac7a
                    }
                }
                moves.Clear();
            }
        }
        //ZL
        
    }



    /*Maybe seperate cpu battle attack function?*/


}
