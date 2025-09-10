
#region IMPORTS

#if GAMBIT_NEUROGUIDE
using gambit.neuroguide;
using System.Collections;
using UnityEngine.Rendering.VirtualTexturing;


#endif

#if GAMBIT_MATHHELPER
using gambit.mathhelper;
#endif

using UnityEngine;

#endregion

/// <summary>
/// Rotate the hypercube a few times
/// </summary>
public class HypercubeSpin : MonoBehaviour, INeuroGuideFocusMeterExperienceInteractable
{
    #region PUBLIC - VARIABLES

    public Animator animator;

    public string stateName;

    #endregion

    #region PRIVATE - VARIABLES

    private int stateHash = 0;

    #endregion

    #region PUBLIC - START

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Convert the state name to a hash for performance
        stateHash = Animator.StringToHash( stateName );

        PlayAnimationDirectly( stateName );
        animator.speed = 0f;
    }

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

    #region PUBLIC - NUEROGUIDE - ON DATA UPDATE

    public void OnFocusDataUpdate(float value)
    {
        PlayAnimationDirectly( stateName, 0, value);
    }

    #endregion

    #region PUBLIC - NEUROGUIDE - ON ABOVE THRESHOLD

    /// <summary>
    /// Called when the NeuroGuideAnimationExperience has a score thats above the threshold value
    /// </summary>
    //------------------------------------//
    public void OnAboveFocusThreshold()
    //------------------------------------//
    {
        //Debug.Log("NeuroGuideInteractableDemo.cs // OnAboveFocusThreshold() // ");

        if (NeuroGuideFocusMeterExperience.system.currentLevel > 5)
        {
            NeuroGuideFocusMeterExperience.system.currentLevel = 5;
        }

        //NeuroGuideFocusMeterExperience.system.currentLevel++;
        
        switch (NeuroGuideFocusMeterExperience.system.currentLevel)
        {
            case 0:
                /*
                NeuroGuideFocusMeterExperience.system.options.numOfLevelsGained = 1f;
                NeuroGuideFocusMeterExperience.system.options.numOfLevelsLost = 1f;

                NeuroGuideFocusMeterExperience.system.options.gainingFocusMultiplier = 1f;
                NeuroGuideFocusMeterExperience.system.options.losingFocusMultiplier = 1f;
                */
                NeuroGuideFocusMeterExperience.system.options.threshold = .2f;

                Debug.Log("HypercubeSpin.cs // OnAboveFocusThreshold Level 0");


                break;

            case 1:
                /*
                NeuroGuideFocusMeterExperience.system.options.numOfLevelsGained = 1f;
                NeuroGuideFocusMeterExperience.system.options.numOfLevelsLost = 1f;

                NeuroGuideFocusMeterExperience.system.options.gainingFocusMultiplier = 1f;
                NeuroGuideFocusMeterExperience.system.options.losingFocusMultiplier = 1f;
                */
                NeuroGuideFocusMeterExperience.system.options.threshold = .4f;

                Debug.Log("HypercubeSpin.cs // OnAboveFocusThreshold Level 1");

                break;

            case 2:
                /*
                NeuroGuideFocusMeterExperience.system.options.numOfLevelsGained = 1f;
                NeuroGuideFocusMeterExperience.system.options.numOfLevelsLost = 1f;

                NeuroGuideFocusMeterExperience.system.options.gainingFocusMultiplier = 1f;
                NeuroGuideFocusMeterExperience.system.options.losingFocusMultiplier = 1f;
                */
                NeuroGuideFocusMeterExperience.system.options.threshold = .6f;
                Debug.Log("HypercubeSpin.cs // OnAboveFocusThreshold Level 2");

                break;

            case 3:
                /*
                NeuroGuideFocusMeterExperience.system.options.numOfLevelsGained = 1f;
                NeuroGuideFocusMeterExperience.system.options.numOfLevelsLost = 1f;

                NeuroGuideFocusMeterExperience.system.options.gainingFocusMultiplier = 1f;
                NeuroGuideFocusMeterExperience.system.options.losingFocusMultiplier = 1f;
                */
                NeuroGuideFocusMeterExperience.system.options.threshold = .8f;
                Debug.Log("HypercubeSpin.cs // OnAboveFocusThreshold Level 3");

                break;

            case 4:
                /*
                NeuroGuideFocusMeterExperience.system.options.numOfLevelsGained = 1f;
                NeuroGuideFocusMeterExperience.system.options.numOfLevelsLost = 1f;

                NeuroGuideFocusMeterExperience.system.options.gainingFocusMultiplier = 1f;
                NeuroGuideFocusMeterExperience.system.options.losingFocusMultiplier = 1f;
                */
                NeuroGuideFocusMeterExperience.system.options.threshold = .99f;
                
                Debug.Log("HypercubeSpin.cs // OnAboveFocusThreshold Level 4");

                break;

            case 5:
                /*
                NeuroGuideFocusMeterExperience.system.options.numOfLevelsGained = 1f;
                NeuroGuideFocusMeterExperience.system.options.numOfLevelsLost = 1f;

                NeuroGuideFocusMeterExperience.system.options.gainingFocusMultiplier = 1f;
                NeuroGuideFocusMeterExperience.system.options.losingFocusMultiplier = 1f;
                */
                Debug.Log("HypercubeSpin.cs // OnAboveFocusThreshold Level 5");

                break;
        }

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
        //Debug.Log("NeuroGuideInteractableDemo // OnBelowFocusThreshold() //");

        //NeuroGuideFocusMeterExperience.system.currentLevel--;

        if (NeuroGuideFocusMeterExperience.system.currentLevel < 0)
        {
            NeuroGuideFocusMeterExperience.system.currentLevel = 0;
        }

        switch (NeuroGuideFocusMeterExperience.system.currentLevel)
        {
            case 0:
                Debug.Log("HypercubeSpin.cs // OnBelowFocusThreshold Level 0");
                StartCoroutine("PauseDataStream");
                break;

            case 1:
                Debug.Log("HypercubeSpin.cs // OnBelowFocusThreshold Level 1");
                StartCoroutine("PauseDataStream");
                break;

            case 2:
                Debug.Log("HypercubeSpin.cs // OnBelowFocusThreshold Level 2");
                StartCoroutine("PauseDataStream");
                break;

            case 3:
                Debug.Log("HypercubeSpin.cs // OnBelowFocusThreshold Level 3");
                StartCoroutine("PauseDataStream");
                break;

            case 4:
                Debug.Log("HypercubeSpin.cs // OnAboveFocusThreshold Level 4");
                
                break;

            case 5:
                Debug.Log("HypercubeSpin.cs // OnBelowFocusThreshold Level 5");
                
                break;
        }
    } //END OnBelowThreshold

    #endregion

    #region PUBLIC - PLAY ANIMATION DIRECTLY

    //-----------------------------------------------------------------//
    public void PlayAnimationDirectly(string stateName, int layer = 0, float normalizedTime = 0f)
    //-----------------------------------------------------------------//
    {
        if (animator != null && animator.gameObject.activeSelf && animator.HasState(0, stateHash ) )
        {
            animator.Play(stateName, 0, normalizedTime);
        }

    } //END PlayAnimationDirectly

    #endregion

    #region PRIVATE - PAUSE DATA STREAM

    //----------------------------------//
    private IEnumerator PauseDataStream()
    //----------------------------------//
    {
        //NeuroGuideManager.system.state = NeuroGuideManager.State.NoData;
        NeuroGuideManager.Instance.enabled = false;

        yield return new WaitForSeconds(.3f);

        //NeuroGuideManager.system.state = NeuroGuideManager.State.ReceivingData;
        NeuroGuideManager.Instance.enabled = true;

    } // END PauseDataStream

    #endregion

} //END HypercubeSpin Class