using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tracks a particular metric
public class Stat
{
    // name of the stat e.g. "iron"
    private string name;

    // parameters
    private float absMin;
    private float absMax;
    private float healthyMin;
    private float healthyMax;

    // current level
    private float curr;

    // diseases associated with this metric
    private Disease[] diseases;

    public Stat(string name, float absMin, float absMax, float healthyMin, float healthyMax) {
        this.name = name;
        this.absMin = absMin;
        this.absMax = absMax;
        this.healthyMin = healthyMin;
        this.healthyMax = healthyMax;
        this.curr = absMin;
    }

    public void add(float val) {
        this.curr += val;
        if (this.curr >= absMax) {
            this.curr = absMax;
        }
    }

    public bool isHealthy() {
        return curr >= healthyMin && curr <= healthyMax;
    }

    public float getAbsMin() {
        return absMin;
    }

    public float getAbsMax() {
        return absMax;
    }

    public float getCurr() {
        return curr;
    }
}
