using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITriggerCheckable
{
    bool IsAggroed { get; set; }
    bool IsWithinAttackDistance { get; set; }

    void SetAggroStatus(bool isAggroed);
    void SetAttackDistanceStatus(bool isWithinAttackDistance);
}
