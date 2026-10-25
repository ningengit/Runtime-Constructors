using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace RuntimeConstructers
{
    /// <summary>
    /// Factory class for creating standard Unity UI (uGUI) elements at runtime
    /// using Unity's built-in DefaultControls and embedded Base64 default sprites.
    /// </summary>
    public class GUIElements
    {
        private const string Base64UISprite =
            "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAACq0lEQVR4nO1XPYgaURAe3fW3iYVdtAiciEIgaGcjBAKmCoIggt1B4MAf8CcgpDwIBKKIgiBcJ4ooaIrAQSCQUkQJHATELtjYB/9/MrPxLc/DwGmUa/xgGN3Zne97896+fSPa7XbgodVqQalUSr9Xq5Xk1+s1KBQK2Af8M3y+yWSydZ+o0WhgOp0C8/TgcrkEQRDgmKCcDDRIEkJeJCK9Xg+j0UgKcsRWtLdobrQXFNqXE+0H2ne0IubtsQCREydBJGV8BTZKY2jXsVhM53Q6wWq1ymV8KLDcQq/Xc3Y6HWc6nb7CS+/R0hQjLhoweZFICRuvxnn77PP5PMFgEMxmMxwKEmyz2SRzu926Uqn0qV6vv8LQG+SaMU5pDXD4GAgEPIlEAo4JGkgqlQKVSuWpVCof8FKcxUSutM+xbKFoNCr9oRW7WCwkz96GfUG5yURRlHw4HIZyuRzFhX6D4Z+SAC75ZTKZFFClRDybzeB/wcRTPrVaLc05rishk8lcwqYKIne/x+Vy8QvxqKABUV7iQAEeWQC3wTwzGo0nIWeg3AaDgfaap+waXwH1vrvdIaDNB3me7BLwKDgLOAs4CzgLOAvgBczm87maPsenxHg8Jvd7l4Bfw+HwwmQynVQAckhcuwTctlqt0KkFtNtt+hx/lQVwn+AiHhSuvF6vsO8J+KHAKYZsNrvE/DeyAGpENrhDMYV8Ph+KRCInEVAoFMjl8Zh2Jwu41yrFa7XaBSr1+P1+ONZ0DAYDqFar0Gw2b/HI946P3W/NZliR141GI4Z2jadYncPhAIvFchBxv9+HbrcLuVyOlv5WY8I4/9Wa0Y1fcDqoNXsJf1uzQ0Ct2TfMWUQvt2ZELrdmrGNlDSM7lG56uTgcCfxhd6s1Y2uAeXorTvEWUGVZD8K3g38A8BxHBF/VD5oAAAAASUVORK5CYII=";

        private const string Base64Background =
            "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAACd0lEQVR4nO1Xv4saURAe3UU9m2AhFilEOIgIkeD9AYGoqFVKEVSEg8CBEDghVcpAIJBUgYBwIKJYpwgqSiD/QfBETGk6C7tgVPyRbzb7lndiQD2XNPvBMLqz++Z7897bnU8NhUIkw+Vykd1u136v12vNbzYbstlsdAjkZ+TxZrPZnftUp9NJ8/mchOcHV6sVKYpCpwSPKcCTZCLsVU7kdrtpOp1qQSnxI9gL2FPYEw4dmhP2HfYNVsa4P0SAk3NOhsrM5AroTK9hb7LZ7FkwGCS/32+UcV+g3MpoNLoYDocXtVrtCpdewz5wjHPxhNmrnJShewfW7XMsFkumUiny+Xx0LJhwIBDQLBKJnDWbzffdbjeO0HPkWoic2h6Q8C6RSCRzuRydEjyRQqHAy5tst9tvcakkYqpU2scoWzGTyZBZSKfT1Gq1XmKj3+DvQCMgjhpwmc/nFVVVTSPgcDgI+0qp1+uXpFdBzpYMh8NkNjgHCCQNAtILJuD1ek0n4PF4+F3zUPyXK+Aws/wCfP4x6Qe7CPwXWAQsAhYBi4BFQCawWC6Xpn8P9K741y4CPyeTyfl92rB9gBxarl0EWr1erxiPx00l0O/3+XPcMQhI/UC5UqlcRaNR5dAOeF9gialara4w/o1BgIWIjluQ+YRupXjqplSg0Wiw+4g28NYgsCWVSuhaz6EN7t2WyxiPx4S2nNCWt9CKv5Jj29JsgYqkOp3ONUwTJqwdWZgcAwgTGgwGBGHym7aEicj5L2nGN37BcrA0e0Z/pdkxYGn2FWOW4Q1pxskNaSYUqxCMQkTqWq5EJ4IsTu9IM7EHhOdTYcYp4MoKDSLLwT/3fBrTaDIx7wAAAABJRU5ErkJggg==";

        private const string Base64Checkmark =
            "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAABhWlDQ1BJQ0MgcHJvZmlsZQAAKJF9kT1Iw0AcxV9TpaKVInYQUchQnSz4hThKFYtgobQVWnUwufQLmjQkKS6OgmvBwY/FqoOLs64OroIg+AHi6OSk6CIl/i8ptIj14Lgf7+497t4BQq3EVLNjHFA1y0hEI2I6syr6XtGDAPowjAmJmXosuZhC2/F1Dw9f78I8q/25P0evkjUZ4BGJ55huWMQbxDObls55nzjICpJCfE48ZtAFiR+5Lrv8xjnvsMAzg0YqMU8cJBbzLSy3MCsYKvE0cUhRNcoX0i4rnLc4q6UKa9yTv9Cf1VaSXKc5hCiWEEMcImRUUEQJFsK0aqSYSNB+pI1/0PHHySWTqwhGjgWUoUJy/OB/8LtbMzc16Sb5I0Dni21/jAC+XaBete3vY9uunwDeZ+BKa/rLNWD2k/RqUwsdAYFt4OK6qcl7wOUOMPCkS4bkSF6aQi4HvJ/RN2WA/luge83trbGP0wcgRV0t3wAHh8BonrLX27y7q7W3f880+vsBvYNyxdTubWUAAAAGYktHRAAAAAAAAPlDu38AAAAJcEhZcwAALiMAAC4jAXilP3YAAAAHdElNRQfmCw8RHwdtoCECAAAAGXRFWHRDb21tZW50AENyZWF0ZWQgd2l0aCBHSU1QV4EOFwAAAaNJREFUWMPtlzFrwkAUx8+0KBShU0ALpYtroTyH0HQMVNwytOCQDimdHPMFDDgFBJdaLn6GFl2Li4t7QhcpblIMCQhFihhJr1NKCFIj1pjhfttBwvvxcv93F4QoFAqFQqH8N51O50HX9Voi5UzTvOQ4bgEAJIrkYZxyjuPkJUl6Xi6XaYQQmkwmZ4npnOu6aVmWBwBAAIBUKhVjPp8frXvvIC7BTCbz1O/3RYQQymazn61W65plWSsxofA7VywWv3u93k0iQwEApNFoNHdSSNf12qajwXGcfKlU+vDlZFkeuK6b3omcXySqZDgUgiDYlmWdblqbifIQISQVkFWjSGqa9miaJo8QQgzDePV6/S6Xy413tpcwxqrfjXWdDIYCAAjGWI1lw0eRDIeiWq2+ep4X2zj7U9K27ZNgKMrl8ng6nbKxj45VkuFQcBy3MAzjattaqW0k2+32b/cKhcLbaDQ699eKoiiSJDX3JrhK0kcQhBdN024ZhiF7PynCn1sUxffZbHacqDueL8nz/NdwOLxI5EUUY6x2u917+r9AoVAolGTxA15E9m3FZltgAAAAAElFTkSuQmCC";

        private const string Base64Knob =
            "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAABhWlDQ1BJQ0MgcHJvZmlsZQAAKJF9kT1Iw0AYht+mSkUqDlYQEcxQnSyIFXGUKhbBQmkrtOpgcukfNGlIUlwcBdeCgz+LVQcXZ10dXAVB8AfE0clJ0UVK/C4ptIjxjuMe3vvel7vvAKFRYarZNQmommWk4jExm1sVA68IYBSDNKMSM/VEejEDz/F1Dx/f7yI8y7vuz9Gn5E0G+ETiOaYbFvEG8cympXPeJw6xkqQQnxNPGHRB4keuyy6/cS46LPDMkJFJzROHiMViB8sdzEqGSjxNHFZUjfKFrMsK5y3OaqXGWvfkLwzmtZU012mNII4lJJCECBk1lFGBhQjtGikmUnQe8/APO/4kuWRylcHIsYAqVEiOH/wPfvfWLESn3KRgDOh+se2PMSCwCzTrtv19bNvNE8D/DFxpbX+1Acx+kl5va+EjoH8buLhua/IecLkDDD3pkiE5kp+WUCgA72f0TTlg4BboXXP71jrH6QOQoV4t3wAHh8B4kbLXPd7d09m3f2ta/fsB1qVyzyTSm1wAAAAGYktHRAD/AP8A/6C9p5MAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAAHdElNRQfmBx8VGAbHBpURAAAE1UlEQVRYw+2Y32sTWRTHv/cmWgpCQQwWJUFoSqUvTWdsTHVkUXaXXYRlCzvgwwb6uoIvCV3YP0CkyG4tCEvxrbDah2UbAqI0LlaJTdgww1gwGOKDBGGcl7JVu+ncydyzD2tFMa2tbZN98Pt2mXu4nznn/jjnAJ+0PbGPNUwkEvs9z/uKiD4johhjLEBEMQBgjFlE5DPGLMbYvT179twuFotLLQFUFGWEiH7o6ur64sSJE1BVFX19feCco6+vDwBQqVQgpUSlUoFhGFhYWMDy8nKOMfaraZqzu+JqVVXjiqIspNNpKhaLtFUVi0VKp9OkKMqCqqrxHQPTdT0wODh4JZlMUjabpe0qm81SMpmkwcHBK7quB7brtS5FUW6Nj4+TEOKdhaSU5Hkeua5L9Xqd6vU6rays0MrKypux67rkeR5JKd+xFULQ+Pg4KYpyq7+/f99GDIGN4IhoYXR0dDiVSiEQ+G+q7/vwPA9CCPi+DykliAhE9MZ2bSylhO/7aDQakFKCMQbOOQKBAE6ePInV1dXoo0ePvj106NBvtm27mwbUdT2wtLT0x+jo6PCFCxcAAFJKuK6LRqPxDsxmRUTwfR++74NzDsYYEokEhBAhy7JimqbNlMtl2hRgR0fHxLlz575PpVIAACEEhBAfBdYMdO0nA4EAjh8/juXl5ej9+/e7nj9/fvuDgKqqarFYbOrixYvgnL8J5U5LSgkpJYLBIOLxOAzDSHDO/7Rtu/b2PN7E8JKu6wgGg3Bdd1fg1uT7PlZXVxEMBqHrOqSUlzb0oKIoI2fOnBk7f/48hBCQUu76U7Z2oI4ePYpqtRpxXXfRtu3H63lwTNf1XQvrRp4UQkDXdQAYaxpiVVUj3d3dw0NDQ2g0Gi1PChqNBoaGhtDd3T2sqmrkPUAiOqtpGoQQbctchBDQNA1EdLYZoDYwMNCSfbfRyR4YGAARae8BMsb6w+Fw2/O/cDgMxlh/Mw9GQqFQ2wFDoRCIKNLMg/s6OzvbDtjZ2QnG2L51L+r/m94O8at6vd52oHq9DiJ61SzENcdx2g7oOA4YY7VmIa7UarW2Az59+hREVG4GeM+yrLYDLi4ugjGWbxbim4VCoe2AhUIBjLGb7wEahlFzHKdQKpXaBlcqleA4TsEwjNp618zlTCbTNsDXa19eNx+0bfux67qfh8PhSE9PT0vhcrkcpqenC6Zpjm2YUXPOf8pkMi1NGqSUyGQyYIz9+MGaxLbtGuf8wMuXL+OJRKIlgJOTk5ifn79qmubUpqo6TdPm8vn8sOd5PceOHdtVuKmpKczMzOSi0Why02VnuVymw4cPZx8+fDji+/4BVVV3Be7atWuYnp6ucM6/vHPnTn1LnQXbtt0jR45cNwxDefHiRU88HgdjbMf23OTkJG7cuJHr6Oj4ulQq/b3l1gcAPHv2rH7q1KnrDx482G+aZnzv3r3Y7unO5XKYmJjA/Pz81Wg0mpybm/tnR/qDqqpqUsqfT58+HR8ZGYGiKFsCM00Ts7OzuHv37l+c87RhGPldaWDGYrHvOOepgwcPDmuahmg0it7eXnDO0dvbCwCoVquQUqJareLJkyfI5/NwHKcgpfzFsqzfW9ICVlU1IqX8hjEWAxB7vV1irz9bAHwAFhFZnPPs28/XJ7VS/wKxLQ+pyCdnyAAAAABJRU5ErkJggg==";

        private const string Base64UIMask =
            "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAAArUlEQVR4nO2W2QqAIBBFpQ36/2+NHiLNgYkKs0YdUWouXHpyPNJ2OmOMKplOFY4AvAH02DZy/mq7YIMAGtsRrylpsYPtbKupABybn7MfaKIA9MybnyFg9uV2+AByhQQQ+8BR4syu/jUUAAEQAAEQgM8BOAp+BwAaleuPSDKiJSOA44Y+AHA4bivSVAAICCSnF2qc6cQHAAtAIFO03Kjj1MFavudxMUd+9x2oD2AD0CEefVmsbD0AAAAASUVORK5CYII=";

        private const string Base64DropdownArrow =
            "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAABhGlDQ1BJQ0MgcHJvZmlsZQAAKJF9kT1Iw0AcxV9TpSoVBTuIOGSoThakijhKFYtgobQVWnUwufQLmjQkKS6OgmvBwY/FqoOLs64OroIg+AHi6OSk6CIl/i8ptIjx4Lgf7+497t4BQqPCVLNrElA1y0jFY2I2tyoGXhHAIHrhR1Ripp5IL2bgOb7u4ePrXYRneZ/7c/QreZMBPpF4jumGRbxBPLNp6Zz3iUOsJCnE58QTBl2Q+JHrsstvnIsOCzwzZGRS88QhYrHYwXIHs5KhEk8ThxVVo3wh67LCeYuzWqmx1j35C4N5bSXNdZqjiGMJCSQhQkYNZVRgIUKrRoqJFO3HPPwjjj9JLplcZTByLKAKFZLjB/+D392ahamomxSMAd0vtv0xBgR2gWbdtr+Pbbt5AvifgSut7a82gNlP0uttLXwEDGwDF9dtTd4DLneA4SddMiRH8tMUCgXg/Yy+KQcM3QJ9a25vrX2cPgAZ6mr5Bjg4BMaLlL3u8e6ezt7+PdPq7wdjgXKhFu6GPwAAAAZiS0dEAAAAAAAA+UO7fwAAAAlwSFlzAAAOwwAADsMBx2+oZAAAAAd0SU1FB+YHEAkEJyBHklAAAACcSURBVFjD7dNLDsMgDEXRpEt6iwJ2EXcXNpt1J6ViEKmQT0HVO8MowJVDloWIiIiIZmFmm5lto9Z/3RyAA/Ajhxxd/2h90d3X6jDpOeQ9Odnb61KqKmUKrZOoJwfAVVVuvYc9kT+P64kcFtcSeWXcejYy5/wJizFK+YnKsxDCM6U0JnAvsnY27rbPPeTO9UROF1dHThtHRERE/+kFyfmdhdXwERIAAAAASUVORK5CYII=";

        private const string Base64InputFieldBackground =
            "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAAC30lEQVR4nO1XTWhaQRAe856aqCBeI0EqAUEoFCSHnIqFBj316sE/CBYCQsGEnnoMFEpqQAqFQE4JJBAvPRSTFBp6E70UAgWP1oveiyYaY+fbuLKKLWh8tId8MKw4u/N9OzvvvR3d7/eTivn5eZqbmxO/b29vxdjr9chkMtEkUNeo8a6urobm6Varla6vr0mOWNjtdknTNJolEFMCm4QQjDqIbDYbNZtN4VSIfWwv2Z6yPYFrUk6272zf2PY4bkU6QA5OQIcyNQN9pRm27UgksuDz+cjj8UycEY6jVavVQKVSCRwfH2/wX2/YsvCBCxvGqIMU6I8WPrdPwWAwFA6Hye12C2Kc4TQ1gPrCBgKBwEKhUHh/cXHxnF0vmKstOUUNKHi3trYWSiaTQp3FYiFd1wciJgEKDtm8ubkRZ51KpchsNofOz8/fsntTztOVwI95UTqRSJDD4RCLIOI+GZAisFMmp1gsRmdnZ6/Yt89TfggB8lFjrPPONafTKQoEAlTyaQRIESBHJhErHo9rBwcH6zILurImtLq6Sna7/e7x6C+YFlI0YqibAAcLCA0EKDt7hGoXlXlP8lEgFmIi9uLiIjLjlj41AxakftbkoyJcLhcy4RwnwDByVcTo+2RIwKSFNq2IvwowUsS4+Dr9YzwIeBDwIOC/EtDudDoWXEKMRKvVwvBrnICfjUZj2ev1GiqgXq8LrnECTovFYtpoAaVSCZ/jLwMByrt5b2dnZ4NvwppRX8R2u027u7tdjr8/EIBrUx+XLOZjNptNb21tGSIgl8th+MDXtMuBgJFWafPo6GiZizEUjUZpaWlpJsS1Wo0ODw8pn8+f8gX1teobbc3anJHwyclJhm07k8ksrKysiLv9NOCmhMrlMnFWUfpDjYnk/FNrhomf+bzQmj2ju9ZsGqA1+8ox96BH/gnyQWsmO1bZMMomst/LbdKMoDanQ62ZrAE5yqv0rIHMyh5EbQd/A+JMPJandV0rAAAAAElFTkSuQmCC";

        private static Sprite _uiSprite;
        private static Sprite _background;
        private static Sprite _checkmark;
        private static Sprite _knob;
        private static Sprite _uiMask;
        private static Sprite _dropdownArrow;
        private static Sprite _inputFieldBackground;
        private static Font _defaultFont;

        protected static Sprite GetUISprite =>
            _uiSprite != null ? _uiSprite : (_uiSprite = CreateSpriteFromBase64("UISprite", Base64UISprite, new Vector4(10, 10, 10, 10)));

        protected static Sprite GetBackground =>
            _background != null ? _background : (_background = CreateSpriteFromBase64("Background", Base64Background, new Vector4(10, 10, 10, 10)));

        protected static Sprite GetCheckmark =>
            _checkmark != null ? _checkmark : (_checkmark = CreateSpriteFromBase64("Checkmark", Base64Checkmark, Vector4.zero));

        protected static Sprite GetKnob =>
            _knob != null ? _knob : (_knob = CreateSpriteFromBase64("Knob", Base64Knob, Vector4.zero));

        protected static Sprite GetUIMask =>
            _uiMask != null ? _uiMask : (_uiMask = CreateSpriteFromBase64("UIMask", Base64UIMask, new Vector4(10, 10, 10, 10)));

        protected static Sprite GetDropdownArrow =>
            _dropdownArrow != null ? _dropdownArrow : (_dropdownArrow = CreateSpriteFromBase64("DropdownArrow", Base64DropdownArrow, Vector4.zero));

        protected static Sprite GetInputFieldBackground =>
            _inputFieldBackground != null ? _inputFieldBackground : (_inputFieldBackground = CreateSpriteFromBase64("InputFieldBackground", Base64InputFieldBackground, new Vector4(10, 10, 10, 10)));

        protected static DefaultControls.Resources UIResources => new DefaultControls.Resources
        {
            standard = GetUISprite,
            background = GetBackground,
            inputField = GetInputFieldBackground,
            knob = GetKnob,
            checkmark = GetCheckmark,
            dropdown = GetDropdownArrow,
            mask = GetUIMask
        };

        protected static Font ArialFont
        {
            get
            {
                if (_defaultFont == null)
                {
                    _defaultFont = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                    if (_defaultFont == null)
                    {
                        _defaultFont = Resources.GetBuiltinResource<Font>("Arial.ttf");
                    }
                    if (_defaultFont == null)
                    {
                        Font[] fonts = Resources.FindObjectsOfTypeAll<Font>();
                        if (fonts.Length > 0) _defaultFont = fonts[0];
                    }
                }
                return _defaultFont;
            }
        }

        private static Sprite CreateSpriteFromBase64(string spriteName, string base64, Vector4 border)
        {
            Texture2D tex = new Texture2D(2, 2)
            {
                name = spriteName + "_Tex",
                hideFlags = HideFlags.DontUnloadUnusedAsset
            };
            tex.LoadImage(Convert.FromBase64String(base64));

            Sprite sp = Sprite.Create(
                tex,
                new Rect(0f, 0f, tex.width, tex.height),
                new Vector2(0.5f, 0.5f),
                100f,
                0,
                SpriteMeshType.Tight,
                border
            );
            sp.name = spriteName;
            sp.hideFlags = HideFlags.DontUnloadUnusedAsset;
            return sp;
        }

        protected static void AddLayerForEach(GameObject root)
        {
            int uiLayer = LayerMask.NameToLayer("UI");
            if (uiLayer < 0) uiLayer = 5;

            Transform[] transforms = root.GetComponentsInChildren<Transform>(true);
            for (int i = 0; i < transforms.Length; i++)
            {
                transforms[i].gameObject.layer = uiLayer;
            }
        }

        protected static T FinalizeControl<T>(GameObject controlGo, GameObject parentCanvas, Vector2 anchoredPosition, string controlName) where T : Component
        {
            controlGo.name = controlName;
            if (parentCanvas != null)
            {
                controlGo.transform.SetParent(parentCanvas.transform, false);
            }

            if (controlGo.TryGetComponent(out RectTransform rectTransform))
            {
                rectTransform.anchoredPosition = anchoredPosition;
            }

            AddLayerForEach(controlGo);
            return controlGo.GetComponent<T>();
        }

        /// <summary>
        /// Creates a ScreenSpaceOverlay Canvas and ensures an EventSystem exists in the scene.
        /// </summary>
        public static Canvas Canvas(string canvasName = "Canvas")
        {
            GameObject canvasGo = new GameObject(canvasName, typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            Canvas canvas = canvasGo.GetComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            AddLayerForEach(canvasGo);

            if (EventSystem.current == null)
            {
                new GameObject("EventSystem", typeof(EventSystem), typeof(StandaloneInputModule));
            }

            return canvas;
        }

        public static RawImage RawImage(GameObject canvas, Vector2 position, string rawImageName = "RawImage")
        {
            GameObject go = DefaultControls.CreateRawImage(UIResources);
            return FinalizeControl<RawImage>(go, canvas, position, rawImageName);
        }

        public static RawImage rawImage(GameObject Canvas, Vector2 position, string RawImageName = "RawImage") =>
            RawImage(Canvas, position, RawImageName);

        public static Image Image(GameObject canvas, Vector2 position, string imageName = "Image")
        {
            GameObject go = DefaultControls.CreateImage(UIResources);
            return FinalizeControl<Image>(go, canvas, position, imageName);
        }

        public static Image image(GameObject Canvas, Vector2 position, string ImageName = "Image") =>
            Image(Canvas, position, ImageName);

        public static Button LegacyButton(GameObject canvas, Vector2 position, string text, int fontSize = 14, string buttonName = "Button (Legacy)")
        {
            GameObject go = DefaultControls.CreateButton(UIResources);
            Text label = go.GetComponentInChildren<Text>();
            if (label != null)
            {
                label.font = ArialFont;
                label.text = text;
                label.fontSize = fontSize;
            }
            return FinalizeControl<Button>(go, canvas, position, buttonName);
        }

        public static Text LegacyText(GameObject canvas, Vector2 position, string text, int fontSize = 14, string textName = "Text (Legacy)")
        {
            GameObject go = DefaultControls.CreateText(UIResources);
            Text uiText = go.GetComponent<Text>();
            uiText.font = ArialFont;
            uiText.text = text;
            uiText.fontSize = fontSize;
            return FinalizeControl<Text>(go, canvas, position, textName);
        }

        public static Image Panel(GameObject canvas, Vector2 position, string panelName = "Panel")
        {
            GameObject go = DefaultControls.CreatePanel(UIResources);
            return FinalizeControl<Image>(go, canvas, position, panelName);
        }

        public static Slider Slider(GameObject canvas, Vector2 position, string sliderName = "Slider")
        {
            GameObject go = DefaultControls.CreateSlider(UIResources);
            return FinalizeControl<Slider>(go, canvas, position, sliderName);
        }

        public static Toggle Toggler(GameObject canvas, Vector2 position, string text, string toggleName = "Toggle")
        {
            GameObject go = DefaultControls.CreateToggle(UIResources);
            Text label = go.GetComponentInChildren<Text>();
            if (label != null)
            {
                label.font = ArialFont;
                label.text = text;
            }
            return FinalizeControl<Toggle>(go, canvas, position, toggleName);
        }

        public static ScrollRect ScrollView(GameObject canvas, Vector2 position, string scrollViewName = "Scroll View")
        {
            GameObject go = DefaultControls.CreateScrollView(UIResources);
            return FinalizeControl<ScrollRect>(go, canvas, position, scrollViewName);
        }

        public static Scrollbar Scrollbar(GameObject canvas, Vector2 position, string scrollbarName = "Scrollbar")
        {
            GameObject go = DefaultControls.CreateScrollbar(UIResources);
            return FinalizeControl<Scrollbar>(go, canvas, position, scrollbarName);
        }

        public static Scrollbar scrollbar(GameObject Canvas, Vector2 position, string ScrollbarName = "Scrollbar") =>
            Scrollbar(Canvas, position, ScrollbarName);

        public static InputField LegacyInputField(GameObject canvas, Vector2 position, string inputFieldText = "", string inputFieldName = "InputField (Legacy)")
        {
            GameObject go = DefaultControls.CreateInputField(UIResources);
            InputField inputField = go.GetComponent<InputField>();
            foreach (Text t in go.GetComponentsInChildren<Text>(true))
            {
                t.font = ArialFont;
            }
            inputField.text = inputFieldText;
            return FinalizeControl<InputField>(go, canvas, position, inputFieldName);
        }

        public static Dropdown LegacyDropDown(GameObject canvas, Vector2 position, string dropDownName = "Dropdown (Legacy)")
        {
            GameObject go = DefaultControls.CreateDropdown(UIResources);
            foreach (Text t in go.GetComponentsInChildren<Text>(true))
            {
                t.font = ArialFont;
            }
            return FinalizeControl<Dropdown>(go, canvas, position, dropDownName);
        }
    }
}
