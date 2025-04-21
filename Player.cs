using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstractSystem
{
    public class Player
    {
        public string name { get; set; }
        public string team { get; set; }
        public string position { get; set; }
        public double receivingYards { get; set; }
        public double rushingYards { get; set; }
        public double passingYards { get; set; }
        public double sacks { get; set; }
        public double pressures { get; set; }
        public double touchdowns { get; set; }
        public int interception { get; set; }
        public double tackles { get; set; }
        public int contractYears { get; set; }
        public double yearlyAvg { get; set; }
        public double contractTotal { get; set; }
        public double quarterBackValue {get; set;}
    }
    // public Player(){
    //     this.name = "George Lopez";
    // }
    // public Player(name, team, position, recievingYards, touchdowns){
    //     //reciever
    // }
    // public Player(name, team, position, passingYards, touchdowns){
    //     //quarterback
    // }
    // public Player(name, team, position, rushingYards){
    //     //running back
    //}
}

