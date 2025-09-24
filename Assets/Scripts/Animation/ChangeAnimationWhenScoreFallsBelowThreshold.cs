#region IMPORTS

using UnityEngine;
using gambit.mathhelper;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Rendering.VirtualTexturing;




#if GAMBIT_NEUROGUIDE
using gambit.neuroguide;
#endif

#endregion

public class ChangeAnimationWhenScoreFallsBelowThreshold : MonoBehaviour, INeuroGuideFocusMeterExperienceInteractable
{
    #region PUBLIC - VARIABLES

    [SerializeField] private NestreLogo nestreLogo;
    [SerializeField] private HyperCube hyperCube;
    [SerializeField] private HyperCubePieces hyperCubePieces;
    [SerializeField] private Animator animator;

    #endregion

    #region PRIVATE - UPDATE

    //------------------------------//
    private void Update()
    //------------------------------//
    {

        if(NeuroGuideFocusMeterExperience.system.currentLevel == 5)
        {
            NeuroGuideFocusMeterExperience.system.preventThresholdLength = 2.5f;
        }

    } // END Update

    #endregion

    #region PUBLIC - NEUROGUIDE - ON ABOVE THRESHOLD

    //-----------------------------------------//
    public void OnAboveFocusThreshold()
    //-----------------------------------------//
    {
        if (NeuroGuideFocusMeterExperience.system == null)
        {
            return;
        }

        if (NeuroGuideFocusMeterExperience.system.options == null)
        {
            return;
        }

        if (NeuroGuideFocusMeterExperience.system.currentScore > NeuroGuideFocusMeterExperience.system.options.threshold)
        {
            // Increment before we hit our switch case
            if (NeuroGuideFocusMeterExperience.system.currentLevel == 0)
            {
                NeuroGuideFocusMeterExperience.system.currentLevel = NeuroGuideFocusMeterExperience.system.options.stages[0].onSuccessStageToJumpTo;
            }
            else if (NeuroGuideFocusMeterExperience.system.currentLevel == 1)
            {
                NeuroGuideFocusMeterExperience.system.currentLevel = NeuroGuideFocusMeterExperience.system.options.stages[1].onSuccessStageToJumpTo;
            }
            else if (NeuroGuideFocusMeterExperience.system.currentLevel == 2)
            {
                NeuroGuideFocusMeterExperience.system.currentLevel = NeuroGuideFocusMeterExperience.system.options.stages[2].onSuccessStageToJumpTo;
            }
            else if (NeuroGuideFocusMeterExperience.system.currentLevel == 3)
            {
                NeuroGuideFocusMeterExperience.system.currentLevel = NeuroGuideFocusMeterExperience.system.options.stages[3].onSuccessStageToJumpTo;
            }
            else if (NeuroGuideFocusMeterExperience.system.currentLevel == 4)
            {
                NeuroGuideFocusMeterExperience.system.currentLevel = NeuroGuideFocusMeterExperience.system.options.stages[4].onSuccessStageToJumpTo;
            }
            else if (NeuroGuideFocusMeterExperience.system.currentLevel == 4)
            {
                NeuroGuideFocusMeterExperience.system.currentLevel = NeuroGuideFocusMeterExperience.system.options.stages[5].onSuccessStageToJumpTo;
            }

            switch (NeuroGuideFocusMeterExperience.system.currentLevel)
            {
                case 0:

                    nestreLogo.logo.gameObject.SetActive(false);
                    hyperCube.hypercube.SetActive(false);

                    NeuroGuideFocusMeterExperience.system.options.threshold = NeuroGuideFocusMeterExperience.system.options.stages[0].threshold;

                    if (NeuroGuideFocusMeterExperience.system.options.showDebugLogs == true)
                    {
                        Debug.Log("ChangeAnimationWhenScoreFallsBelowThreshold.cs // OnAboveFocusThreshold Level 0");
                    }

                    break;

                case 1:

                    nestreLogo.logo.gameObject.SetActive(false);
                    hyperCube.hypercube.SetActive(false);

                    NeuroGuideFocusMeterExperience.system.options.threshold = NeuroGuideFocusMeterExperience.system.options.stages[1].threshold;

                    if (NeuroGuideFocusMeterExperience.system.options.showDebugLogs == true)
                    {
                        Debug.Log("ChangeAnimationWhenScoreFallsBelowThreshold.cs // OnAboveFocusThreshold Level 1");
                    }

                    break;

                case 2:

                    nestreLogo.logo.gameObject.SetActive(false);
                    hyperCube.hypercube.SetActive(false);

                    NeuroGuideFocusMeterExperience.system.options.threshold = NeuroGuideFocusMeterExperience.system.options.stages[2].threshold;

                    if (NeuroGuideFocusMeterExperience.system.options.showDebugLogs == true)
                    {
                        Debug.Log("ChangeAnimationWhenScoreFallsBelowThreshold.cs // OnAboveFocusThreshold Level 2");
                    }

                    break;

                case 3:

                    nestreLogo.logo.gameObject.SetActive(false);
                    hyperCube.hypercube.SetActive(false);

                    NeuroGuideFocusMeterExperience.system.options.threshold = NeuroGuideFocusMeterExperience.system.options.stages[3].threshold;

                    if (NeuroGuideFocusMeterExperience.system.options.showDebugLogs == true)
                    {
                        Debug.Log("ChangeAnimationWhenScoreFallsBelowThreshold.cs // OnAboveFocusThreshold Level 3");
                    }

                    break;

                case 4:

                    nestreLogo.logo.gameObject.SetActive(false);
                    hyperCube.hypercube.SetActive(false);
                    hyperCubePieces.gameObject.SetActive(true);

                    NeuroGuideFocusMeterExperience.system.options.threshold = NeuroGuideFocusMeterExperience.system.options.stages[4].threshold;

                    if (NeuroGuideFocusMeterExperience.system.options.showDebugLogs == true)
                    {
                        Debug.Log("ChangeAnimationWhenScoreFallsBelowThreshold.cs // OnAboveFocusThreshold Level 4");
                    }

                    break;

                case 5:

                    hyperCubePieces.gameObject.SetActive(false);
                    nestreLogo.logo.gameObject.SetActive(true);
                    hyperCube.hypercube.SetActive(true);

                    NeuroGuideFocusMeterExperience.system.options.threshold = NeuroGuideFocusMeterExperience.system.options.stages[5].threshold;
                    NeuroGuideFocusMeterExperience.system.hasReachedThreshold = false;

                    if (NeuroGuideFocusMeterExperience.system.options.showDebugLogs == true)
                    {
                        Debug.Log("ChangeAnimationWhenScoreFallsBelowThreshold.cs // OnAboveFocusThreshold Level 5");
                    }

                    break;
            }
        }
    } // END OnAboveFocusThreshold

    #endregion

    #region PUBLIC - NEUROGUIDE - ON BELOW THRESHOLD

    /// <summary>
    /// Called by the NeuroGuideAnimationExperience when the score goes below the threshold.
    /// We set the score to an arbitrary value, resetting the animation to a far earlier state
    /// </summary>
    //--------------------------------------//
    public void OnBelowFocusThreshold()
    //--------------------------------------//
    {

        if (NeuroGuideFocusMeterExperience.system.currentScore < NeuroGuideFocusMeterExperience.system.options.threshold)
        {
            // Meaning we just went above the threshold

            if (NeuroGuideFocusMeterExperience.system.currentLevel < 0)
            {
                NeuroGuideFocusMeterExperience.system.currentLevel = 0;
            }

            if (NeuroGuideFocusMeterExperience.system == null)
            {
                Debug.Log("NeuroGuideFocusExperience.cs // CheckIfScoreIsBelowThreshold() // System is null");

                return;
            }
            if (NeuroGuideFocusMeterExperience.system.options == null)
            {
                Debug.Log("NeuroGuideFocusExperience.cs // CheckIfScoreIsBelowThreshold() // Options is null");

                return;
            }

            switch (NeuroGuideFocusMeterExperience.system.currentLevel)
            {
                case 0:

                    NeuroGuideFocusMeterExperience.system.options.threshold = NeuroGuideFocusMeterExperience.system.options.stages[0].threshold;
                    NeuroGuideFocusMeterExperience.system.currentLevel = NeuroGuideFocusMeterExperience.system.options.stages[0].onFailureStageToJumpTo;

                    if (NeuroGuideFocusMeterExperience.system.options.showDebugLogs == true)
                    {
                        Debug.Log("NeuroGuideFocusExperience.cs // CheckIfScoreIsBelowThreshold() // We are at Level 0");
                    }

                    break;

                case 1:

                    NeuroGuideFocusMeterExperience.system.options.threshold = NeuroGuideFocusMeterExperience.system.options.stages[1].threshold;
                    NeuroGuideFocusMeterExperience.system.currentLevel = NeuroGuideFocusMeterExperience.system.options.stages[1].onFailureStageToJumpTo;

                    if (NeuroGuideFocusMeterExperience.system.options.showDebugLogs == true)
                    {
                        Debug.Log("NeuroGuideFocusExperience.cs // CheckIfScoreIsBelowThreshold() // We are at Level 1 going back to Level 0");
                    }

                    break;

                case 2:

                    NeuroGuideFocusMeterExperience.system.options.threshold = NeuroGuideFocusMeterExperience.system.options.stages[2].threshold;
                    NeuroGuideFocusMeterExperience.system.currentLevel = NeuroGuideFocusMeterExperience.system.options.stages[2].onFailureStageToJumpTo;

                    if (NeuroGuideFocusMeterExperience.system.options.showDebugLogs == true)
                    {
                        Debug.Log("NeuroGuideFocusExperience.cs // CheckIfScoreIsBelowThreshold() // We are at Level 2 going back to Level 1");
                    }

                    break;

                case 3:

                    NeuroGuideFocusMeterExperience.system.options.threshold = NeuroGuideFocusMeterExperience.system.options.stages[3].threshold;
                    NeuroGuideFocusMeterExperience.system.currentLevel = NeuroGuideFocusMeterExperience.system.options.stages[3].onFailureStageToJumpTo;

                    if (NeuroGuideFocusMeterExperience.system.options.showDebugLogs == true)
                    {
                        Debug.Log("NeuroGuideFocusExperience.cs // CheckIfScoreIsBelowThreshold() // We are at Level 3 going back to Level 2");
                    }

                    break;

                case 4:

                    NeuroGuideFocusMeterExperience.system.options.threshold = NeuroGuideFocusMeterExperience.system.options.stages[4].threshold;
                    NeuroGuideFocusMeterExperience.system.currentLevel = NeuroGuideFocusMeterExperience.system.options.stages[4].onFailureStageToJumpTo;

                    if (NeuroGuideFocusMeterExperience.system.options.showDebugLogs == true)
                    {
                        Debug.Log("NeuroGuideFocusExperience.cs // CheckIfScoreIsBelowThreshold() // We are at Level 4 going back to level 3");
                    }

                    break;

                case 5:

                    if(nestreLogo.logo.gameObject.activeSelf == true)
                    {
                        nestreLogo.logo.gameObject.SetActive(false);
                        hyperCube.hypercube.SetActive(false);
                    }
                    
                    NeuroGuideFocusMeterExperience.system.options.threshold = NeuroGuideFocusMeterExperience.system.options.stages[2].threshold;
                    NeuroGuideFocusMeterExperience.system.currentLevel = NeuroGuideFocusMeterExperience.system.options.stages[5].onFailureStageToJumpTo;
                    NeuroGuideFocusMeterExperience.system.currentProgressInSeconds = (NeuroGuideFocusMeterExperience.system.options.totalDurationInSeconds / 5) * 2;
                    NeuroGuideFocusMeterExperience.system.currentScore = NeuroGuideFocusMeterExperience.system.currentProgressInSeconds / NeuroGuideFocusMeterExperience.system.options.totalDurationInSeconds;

                    StartCoroutine("IWait");

                    if(hyperCubePieces.gameObject.activeSelf == false)
                    {
                        hyperCubePieces.gameObject.SetActive(true);
                    }

                    if (NeuroGuideFocusMeterExperience.system.options.showDebugLogs == true)
                    {
                        Debug.Log("NeuroGuideFocusExperience.cs // CheckIfScoreIsBelowThreshold() // We are at Level 5 going back to level 3");
                    }

                    break;
            }
        }

    } //END OnBelowThreshold Method

    #endregion

    //---------------------------------//
    private IEnumerator IWait()
    //---------------------------------//
    {
        NeuroGuideManager.Instance.enabled = false;
        yield return new WaitForSeconds(.33f);
        NeuroGuideManager.Instance.enabled = true;
        //NeuroGuideFocusMeterExperience.system.preventThresholdLength = 0;

    } // END IWait

    #region PUBLIC - NEUROGUIDE - ON DATA UPDATE

    //-----------------------------------------------------------//
    public void OnFocusDataUpdate(float normalizedValue)
    //-----------------------------------------------------------
    {
        //Debug.Log( normalizedValue );
        //Debug.Log( NeuroGuideAnimationExperience.system.currentProgressInSeconds );

    } // END OnFocusDataUpdate

    #endregion

    #region PUBLIC - NEUROGUIDE - ON RECIEVING REWARD CHANGED

    //---------------------------------------------------------------------//
    public void OnRecievingFocusRewardChanged(bool isRecievingReward)
    //---------------------------------------------------------------------//
    {

    } // END OnRecievingFocusRewardChanged

    #endregion

} //END ChangeScoreWhenBelowThreshold Class