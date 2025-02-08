using UnityEngine;

public class PlayerStatus
{
    //Player Stats:
    public double fitness {get; set;}
    public double awakeness{get; set;}
    public double sanity{get; set;}
    public double selfEsteem{get; set;}


    public PlayerStatus(double fitness, double awakeness, double sanity, double selfEsteem){
        this.fitness = fitness;
        this.awakeness = awakeness;
        this.sanity = sanity;
        this.selfEsteem = selfEsteem;
    }

    public PlayerStatus() : this(0,0,0,0) {}

    /// <summary>
    /// Increments the fitness stat by a specified value
    /// </summary>
    /// <param name="value">The increment value</param>
    public void adjustFitness(double value){
        this.fitness += value;
    }

    /// <summary>
    /// Increments the Awakeness stat by a specified value
    /// </summary>
    /// <param name="value">The increment value</param>
    public void adjustAwakeness(double value){
        this.awakeness += value;
    }

    /// <summary>
    /// Increments the Sanity stat by a specified value
    /// </summary>
    /// <param name="value">The increment value</param>
    public void adjustSanity(double value){
        this.sanity += value;
    }

    /// <summary>
    /// Increments the Self Esteem stat by a specified value
    /// </summary>
    /// <param name="value">The increment value</param>
    public void adjustSelfEsteem(double value){
        this.selfEsteem += value;
    }

}
