using UnityEngine;

public class Shop : MonoBehaviour
{
    

    public TurretBlueprint standartTurret;
    public TurretBlueprint missileLauncher;
    public TurretBlueprint laserBeamer;
    BuildManager buildManager;
    
    void Start()
    {
        buildManager = BuildManager.instance;
    }
    
    public void SelectStandartTurret()
    {
        Debug.Log("Standart Turret Pusrchased");
        buildManager.SelectTurretToBuild(standartTurret);   
    }
    
    public void SelectMissileLauncher()
    {
        Debug.Log("Missile Launcher Pusrchased");
        buildManager.SelectTurretToBuild(missileLauncher);
    }
    
    public void SelectLaserBeamer()
    {
        Debug.Log("Laser Beamer Pusrchased");
        buildManager.SelectTurretToBuild(laserBeamer);   
    }
}
