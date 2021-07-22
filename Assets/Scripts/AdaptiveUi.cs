﻿using UnityEngine;

public class AdaptiveUi : MonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] RectTransform _panel;
    [SerializeField] Canvas canvas;
#pragma warning restore 0649
    Rect _lastSafeArea;

    private void Awake()
    {
        if (Screen.safeArea != _lastSafeArea)
        {
            ApplySafeArea(Screen.safeArea);
        }
    }

    private void ApplySafeArea(Rect area)
    {
        var safeArea = Screen.safeArea;

        var anchorMin = safeArea.position;
        var anchorMax = safeArea.position + safeArea.size;
        anchorMin.x /= canvas.pixelRect.width;
        anchorMin.y /= canvas.pixelRect.height;
        anchorMax.x /= canvas.pixelRect.width;
        anchorMax.y /= canvas.pixelRect.height;

        _panel.anchorMin = anchorMin;
        _panel.anchorMax = anchorMax;
        
        _lastSafeArea = area;
    }
}