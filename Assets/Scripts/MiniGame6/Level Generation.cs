using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public Transform Floor;
    public Transform Slide;
    public Transform Jump;
    public Transform Hide;
    public Transform Dash;
    public Transform End;
    public Vector3 _spawnPosition;
    public Vector3 _nextSpawnPosition;
    public bool MustBeFloor = true;
    public int GeneratedNumber;
    public int NumberOfPlatforms;

    private void Start()
    {
        SpawnFloor();
    }
    void Update()
    {
        if (NumberOfPlatforms >= 1)
        {
            if (MustBeFloor == true)
            {
                _spawnPosition = _spawnPosition + _nextSpawnPosition;
                MustBeFloor = false;
                NumberOfPlatforms = NumberOfPlatforms - 1;
                SpawnFloor();
            }
            else
            {
                GeneratedNumber = Random.Range(1, 6);
                if (GeneratedNumber == 1)
                {
                    _spawnPosition = _spawnPosition + _nextSpawnPosition;
                    MustBeFloor = true;
                    NumberOfPlatforms = NumberOfPlatforms - 1;
                    SpawnFloor();
                }
                if (GeneratedNumber == 2)
                {
                    _spawnPosition = _spawnPosition + _nextSpawnPosition;
                    MustBeFloor = true;
                    NumberOfPlatforms = NumberOfPlatforms - 1;
                    SpawnSlide();
                }
                if (GeneratedNumber == 3)
                {
                    _spawnPosition = _spawnPosition + _nextSpawnPosition;
                    MustBeFloor = true;
                    NumberOfPlatforms = NumberOfPlatforms - 1;
                    SpawnJump();
                }
                if (GeneratedNumber == 4)
                {
                    _spawnPosition = _spawnPosition + _nextSpawnPosition;
                    MustBeFloor = true;
                    NumberOfPlatforms = NumberOfPlatforms - 1;
                    SpawnHide();
                }
                if (GeneratedNumber == 5)
                {
                    _spawnPosition = _spawnPosition + _nextSpawnPosition;
                    MustBeFloor = true;
                    NumberOfPlatforms = NumberOfPlatforms - 1;
                    SpawnDash();
                }
            }
        }
        if(NumberOfPlatforms == 0)
        {
            NumberOfPlatforms = NumberOfPlatforms - 1;
            SpawnEnd();
        }
    }
    void SpawnFloor()
    {
        Transform InstancitedAsset;
        InstancitedAsset = (Transform)Instantiate(this.Floor, this._spawnPosition, Quaternion.identity);
    }
    void SpawnSlide()
    {
        Transform InstancitedAsset;
        InstancitedAsset = (Transform)Instantiate(this.Slide, this._spawnPosition, Quaternion.identity);
    }
    void SpawnJump()
    {
        Transform InstancitedAsset;
        InstancitedAsset = (Transform)Instantiate(this.Jump, this._spawnPosition, Quaternion.identity);
    }
    void SpawnHide()
    {
        Transform InstancitedAsset;
        InstancitedAsset = (Transform)Instantiate(this.Hide, this._spawnPosition, Quaternion.identity);
    }
    void SpawnDash()
    {
        Transform InstancitedAsset;
        InstancitedAsset = (Transform)Instantiate(this.Dash, this._spawnPosition, Quaternion.identity);
    }
    void SpawnEnd()
    {
        Transform InstancitedAsset;
        InstancitedAsset = (Transform)Instantiate(this.End, this._spawnPosition, Quaternion.identity);
    }
}
