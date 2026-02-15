#region IMPORTS

#if GAMBIT_NEUROGUIDE
using gambit.neuroguide;
#endif

#if GAMBIT_MATHHELPER
using gambit.mathhelper;
#endif

using UnityEngine;
using System.Collections.Generic;

#endregion

/// <summary>
/// Keeps the Hypercube visual component up to date with the NeuroGuide hardware data
/// </summary>
public class HyperCube : MonoBehaviour, INeuroGuideFocusMeterExperienceInteractable
{

    #region PUBLIC - VARIABLES

    public GameObject hypercube;
    public Animator animator;

    public string AnimationSpeedMultiplierVariableName = "AnimationSpeed";

    public List<float> animationSearchList = new List<float>();

    public List<float> animationReturnList = new List<float>();

    #endregion

    #region PUBLIC - START

    /// <summary>
    /// Unity lifecycle Start Method
    /// </summary>
    //---------------------------------//
    public void Start()
    //---------------------------------//
    {

        hypercube.SetActive( false );

    } //END Start

    #endregion

    #region PUBLIC - NEUROGUIDE - ON RECIEVING REWARD CHANGED

    /// <summary>
    /// Called when the NeuroGuide software starts or stops sending the user a reward
    /// </summary>
    /// <param name="isRecievingReward">Is the user currently recieiving a reward?</param>
    //--------------------------------------------------------------------//
    public void OnRecievingFocusRewardChanged( bool isRecievingReward )
    //--------------------------------------------------------------------//
    {

    } //END OnRecievingRewardChanged

    #endregion

    #region PUBLIC - NEUROGUIDE - ON DATA UPDATE

    /// <summary>
    /// Called when the NeuroGuide hardware updates
    /// </summary>
    /// <param name="system">The NeuroGuide system object</param>
    //------------------------------------------------------------------------//
    public void OnFocusDataUpdate( float value )
    //------------------------------------------------------------------------//
    {
        
    } //END OnDataUpdate Method

    #endregion

    #region PUBLIC - NEUROGUIDE - ON ABOVE THRESHOLD

    /// <summary>
    /// Called when the NeuroGuideAnimationExperience has a score thats above the threshold value
    /// </summary>
    //------------------------------------//
    public void OnAboveFocusThreshold()
    //------------------------------------//
    {
        /*
        switch (NeuroGuideFocusMeterExperience.system.currentLevel)
        {
            case 5:
                hypercube.SetActive(true);

                Debug.Log("HyperCube.cs // Showing HyperCube");

                break;
        }
        */
    } //END OnAboveThreshold

    #endregion

    #region PUBLIC - NEUROGUIDE - ON BELOW THRESHOLD

    /// <summary>
    /// Called when the NeuroGuideAnimationExperience has a score thats below the threshold value
    /// </summary>
    //-------------------------------------//
    public void OnBelowFocusThreshold()
    //-------------------------------------//
    {
        //hypercube.SetActive( false );

    } //END OnBelowThreshold

    #endregion

    #region PUBLIC - PLAY ANIMATION DIRECTLY

    //-----------------------------------------------------------------//
    public void PlayAnimationDirectly(string stateName, int layer = 0, float normalizedTime = 0f)
    //-----------------------------------------------------------------//
    {
        if (animator != null && animator.gameObject.activeSelf)
        {
            animator.Play(stateName, 0, normalizedTime);
        }

    } //END PlayAnimationDirectly

    #endregion

} //END HyperCube Class