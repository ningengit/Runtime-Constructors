using UnityEngine.UI;
using UnityEngine;
using System;
using System.Collections.Generic;

namespace RuntimeConstructers
{
    /// <summary>
    /// Class for creating basic UI Objects.
    /// </summary>
    public class GUIElements
    {
        protected static Sprite UISprite()
        {
            Texture2D tex = new Texture2D(2, 2);
            string UISprite = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAACq0lEQVR4nO1XPYgaURAe3fW3iYVdtAiciEIgaGcjBAKmCoIggt1B4MAf8CcgpDwIBKKIgiBcJ4ooaIrAQSCQUkQJHATELtjYB/9/MrPxLc/DwGmUa/xgGN3Zne97896+fSPa7XbgodVqQalUSr9Xq5Xk1+s1KBQK2Af8M3y+yWSydZ+o0WhgOp0C8/TgcrkEQRDgmKCcDDRIEkJeJCK9Xg+j0UgKcsRWtLdobrQXFNqXE+0H2ne0IubtsQCREydBJGV8BTZKY2jXsVhM53Q6wWq1ymV8KLDcQq/Xc3Y6HWc6nb7CS+/R0hQjLhoweZFICRuvxnn77PP5PMFgEMxmMxwKEmyz2SRzu926Uqn0qV6vv8LQG+SaMU5pDXD4GAgEPIlEAo4JGkgqlQKVSuWpVCof8FKcxUSutM+xbKFoNCr9oRW7WCwkz96GfUG5yURRlHw4HIZyuRzFhX6D4Z+SAC75ZTKZFFClRDybzeB/wcRTPrVaLc05rishk8lcwqYKIne/x+Vy8QvxqKABUV7iQAEeWQC3wTwzGo0nIWeg3AaDgfaap+waXwH1vrvdIaDNB3me7BLwKDgLOAs4CzgLOAvgBczm87maPsenxHg8Jvd7l4Bfw+HwwmQynVQAckhcuwTctlqt0KkFtNtt+hx/lQVwn+AiHhSuvF6vsO8J+KHAKYZsNrvE/DeyAGpENrhDMYV8Ph+KRCInEVAoFMjl8Zh2Jwu41yrFa7XaBSr1+P1+ONZ0DAYDqFar0Gw2b/HI946P3W/NZliR141GI4Z2jadYncPhAIvFchBxv9+HbrcLuVyOlv5WY8I4/9Wa0Y1fcDqoNXsJf1uzQ0Ct2TfMWUQvt2ZELrdmrGNlDSM7lG56uTgcCfxhd6s1Y2uAeXorTvEWUGVZD8K3g38A8BxHBF/VD5oAAAAASUVORK5CYII=";
            tex.LoadImage(Convert.FromBase64String(UISprite));
            Sprite sp = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10, 10, 10, 10));
            sp.name = "UISprite";
            return sp;
        }

        protected static Sprite GetUISprite
        {
            get
            {
                if (uisp == null)
                {
                    uisp = UISprite();
                }
                return uisp;
            }
        }

        private static Sprite uisp;

        protected static Sprite Background()
        {
            Texture2D Backgroundtex = new Texture2D(2, 2);
            string BackgroundSprite = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAACd0lEQVR4nO1Xv4saURAe3UU9m2AhFilEOIgIkeD9AYGoqFVKEVSEg8CBEDghVcpAIJBUgYBwIKJYpwgqSiD/QfBETGk6C7tgVPyRbzb7lndiQD2XNPvBMLqz++Z7897bnU8NhUIkw+Vykd1u136v12vNbzYbstlsdAjkZ+TxZrPZnftUp9NJ8/mchOcHV6sVKYpCpwSPKcCTZCLsVU7kdrtpOp1qQSnxI9gL2FPYEw4dmhP2HfYNVsa4P0SAk3NOhsrM5AroTK9hb7LZ7FkwGCS/32+UcV+g3MpoNLoYDocXtVrtCpdewz5wjHPxhNmrnJShewfW7XMsFkumUiny+Xx0LJhwIBDQLBKJnDWbzffdbjeO0HPkWoic2h6Q8C6RSCRzuRydEjyRQqHAy5tst9tvcakkYqpU2scoWzGTyZBZSKfT1Gq1XmKj3+DvQCMgjhpwmc/nFVVVTSPgcDgI+0qp1+uXpFdBzpYMh8NkNjgHCCQNAtILJuD1ek0n4PF4+F3zUPyXK+Aws/wCfP4x6Qe7CPwXWAQsAhYBi4BFQCawWC6Xpn8P9K741y4CPyeTyfl92rB9gBxarl0EWr1erxiPx00l0O/3+XPcMQhI/UC5UqlcRaNR5dAOeF9gialara4w/o1BgIWIjluQ+YRupXjqplSg0Wiw+4g28NYgsCWVSuhaz6EN7t2WyxiPx4S2nNCWt9CKv5Jj29JsgYqkOp3ONUwTJqwdWZgcAwgTGgwGBGHym7aEicj5L2nGN37BcrA0e0Z/pdkxYGn2FWOW4Q1pxskNaSYUqxCMQkTqWq5EJ4IsTu9IM7EHhOdTYcYp4MoKDSLLwT/3fBrTaDIx7wAAAABJRU5ErkJggg==";
            Backgroundtex.LoadImage(Convert.FromBase64String(BackgroundSprite));
            Sprite sp = Sprite.Create(Backgroundtex, new Rect(0.0f, 0.0f, Backgroundtex.width, Backgroundtex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10, 10, 10, 10));
            sp.name = "Background";
            return sp;
        }

        protected static Sprite GetBackground
        {
            get
            {
                if (background == null)
                {
                    background = Background();
                }
                return background;
            }
        }

        private static Sprite background;

        protected static Sprite Checkmark()
        {
            Texture2D Checkmark_image = new Texture2D(2, 2);
            string checkmarksp = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAABhWlDQ1BJQ0MgcHJvZmlsZQAAKJF9kT1Iw0AcxV9TpaKVInYQUchQnSz4hThKFYtgobQVWnUwufQLmjQkKS6OgmvBwY/FqoOLs64OroIg+AHi6OSk6CIl/i8ptIj14Lgf7+497t4BQq3EVLNjHFA1y0hEI2I6syr6XtGDAPowjAmJmXosuZhC2/F1Dw9f78I8q/25P0evkjUZ4BGJ55huWMQbxDObls55nzjICpJCfE48ZtAFiR+5Lrv8xjnvsMAzg0YqMU8cJBbzLSy3MCsYKvE0cUhRNcoX0i4rnLc4q6UKa9yTv9Cf1VaSXKc5hCiWEEMcImRUUEQJFsK0aqSYSNB+pI1/0PHHySWTqwhGjgWUoUJy/OB/8LtbMzc16Sb5I0Dni21/jAC+XaBete3vY9uunwDeZ+BKa/rLNWD2k/RqUwsdAYFt4OK6qcl7wOUOMPCkS4bkSF6aQi4HvJ/RN2WA/luge83trbGP0wcgRV0t3wAHh8BonrLX27y7q7W3f880+vsBvYNyxdTubWUAAAAGYktHRAAAAAAAAPlDu38AAAAJcEhZcwAALiMAAC4jAXilP3YAAAAHdElNRQfmCw8RHwdtoCECAAAAGXRFWHRDb21tZW50AENyZWF0ZWQgd2l0aCBHSU1QV4EOFwAAAaNJREFUWMPtlzFrwkAUx8+0KBShU0ALpYtroTyH0HQMVNwytOCQDimdHPMFDDgFBJdaLn6GFl2Li4t7QhcpblIMCQhFihhJr1NKCFIj1pjhfttBwvvxcv93F4QoFAqFQqH8N51O50HX9Voi5UzTvOQ4bgEAJIrkYZxyjuPkJUl6Xi6XaYQQmkwmZ4npnOu6aVmWBwBAAIBUKhVjPp8frXvvIC7BTCbz1O/3RYQQymazn61W65plWSsxofA7VywWv3u93k0iQwEApNFoNHdSSNf12qajwXGcfKlU+vDlZFkeuK6b3omcXySqZDgUgiDYlmWdblqbifIQISQVkFWjSGqa9miaJo8QQgzDePV6/S6Xy413tpcwxqrfjXWdDIYCAAjGWI1lw0eRDIeiWq2+ep4X2zj7U9K27ZNgKMrl8ng6nbKxj45VkuFQcBy3MAzjattaqW0k2+32b/cKhcLbaDQ699eKoiiSJDX3JrhK0kcQhBdN024ZhiF7PynCn1sUxffZbHacqDueL8nz/NdwOLxI5EUUY6x2u917+r9AoVAolGTxA15E9m3FZltgAAAAAElFTkSuQmCC";
            Checkmark_image.LoadImage(Convert.FromBase64String(checkmarksp));
            Sprite sp = Sprite.Create(Checkmark_image, new Rect(0.0f, 0.0f, Checkmark_image.width, Checkmark_image.height), new Vector2(20f, 20f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(0, 0, 0, 0));
            sp.name = "Checkmark";
            return sp;
        }

        protected static Sprite GetCheckmark
        {
            get
            {
                if (checkmark == null)
                {
                    checkmark = Checkmark();
                }
                return checkmark;
            }
        }

        private static Sprite checkmark;

        protected static Sprite Knob()
        {
            string knobsp = "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";
            Texture2D Knob_Sprite = new Texture2D(2, 2);
            Knob_Sprite.LoadImage(Convert.FromBase64String(knobsp));
            Sprite sp = Sprite.Create(Knob_Sprite, new Rect(0.0f, 0.0f, Knob_Sprite.width, Knob_Sprite.height), new Vector2(20f, 20f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(0, 0, 0, 0));
            sp.name = "Knob";
            return sp;
        }

        protected static Sprite GetKnob
        {
            get
            {
                if (knob == null)
                {
                    knob = Knob();
                }
                return knob;
            }
        }

        private static Sprite knob;

        protected static Sprite UIMask()
        {
            Texture2D UImasktex = new Texture2D(2, 2);
            string UImaskSprite = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAAArUlEQVR4nO2W2QqAIBBFpQ36/2+NHiLNgYkKs0YdUWouXHpyPNJ2OmOMKplOFY4AvAH02DZy/mq7YIMAGtsRrylpsYPtbKupABybn7MfaKIA9MybnyFg9uV2+AByhQQQ+8BR4syu/jUUAAEQAAEQgM8BOAp+BwAaleuPSDKiJSOA44Y+AHA4bivSVAAICCSnF2qc6cQHAAtAIFO03Kjj1MFavudxMUd+9x2oD2AD0CEefVmsbD0AAAAASUVORK5CYII=";
            UImasktex.LoadImage(Convert.FromBase64String(UImaskSprite));
            Sprite sp = Sprite.Create(UImasktex, new Rect(0.0f, 0.0f, UImasktex.width, UImasktex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10, 10, 10, 10));
            sp.name = "UIMask";
            return sp;
        }

        protected static Sprite GetUIMask
        {
            get
            {
                if (uIMask == null)
                {
                    uIMask = UIMask();
                }
                return uIMask;
            }
        }

        private static Sprite uIMask;

        protected static Sprite DropdownArrow()
        {
            Texture2D DropdownArrowtex = new Texture2D(2, 2);
            string DropdownArrow = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAABhGlDQ1BJQ0MgcHJvZmlsZQAAKJF9kT1Iw0AcxV9TpSoVBTuIOGSoThakijhKFYtgobQVWnUwufQLmjQkKS6OgmvBwY/FqoOLs64OroIg+AHi6OSk6CIl/i8ptIjx4Lgf7+497t4BQqPCVLNrElA1y0jFY2I2tyoGXhHAIHrhR1Ripp5IL2bgOb7u4ePrXYRneZ/7c/QreZMBPpF4jumGRbxBPLNp6Zz3iUOsJCnE58QTBl2Q+JHrsstvnIsOCzwzZGRS88QhYrHYwXIHs5KhEk8ThxVVo3wh67LCeYuzWqmx1j35C4N5bSXNdZqjiGMJCSQhQkYNZVRgIUKrRoqJFO3HPPwjjj9JLplcZTByLKAKFZLjB/+D392ahamomxSMAd0vtv0xBgR2gWbdtr+Pbbt5AvifgSut7a82gNlP0uttLXwEDGwDF9dtTd4DLneA4SddMiRH8tMUCgXg/Yy+KQcM3QJ9a25vrX2cPgAZ6mr5Bjg4BMaLlL3u8e6ezt7+PdPq7wdjgXKhFu6GPwAAAAZiS0dEAAAAAAAA+UO7fwAAAAlwSFlzAAAOwwAADsMBx2+oZAAAAAd0SU1FB+YHEAkEJyBHklAAAACcSURBVFjD7dNLDsMgDEXRpEt6iwJ2EXcXNpt1J6ViEKmQT0HVO8MowJVDloWIiIiIZmFmm5lto9Z/3RyAA/Ajhxxd/2h90d3X6jDpOeQ9Odnb61KqKmUKrZOoJwfAVVVuvYc9kT+P64kcFtcSeWXcejYy5/wJizFK+YnKsxDCM6U0JnAvsnY27rbPPeTO9UROF1dHThtHRERE/+kFyfmdhdXwERIAAAAASUVORK5CYII=";
            DropdownArrowtex.LoadImage(Convert.FromBase64String(DropdownArrow));
            Sprite sp = Sprite.Create(DropdownArrowtex, new Rect(0.0f, 0.0f, DropdownArrowtex.width, DropdownArrowtex.height), new Vector2(20f, 20f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(0, 0, 0, 0));
            sp.name = "DropdownArrow";
            return sp;
        }

        protected static Sprite GetDropdownArrow
        {
            get
            {
                if (dropdownArrow == null)
                {
                    dropdownArrow = DropdownArrow();
                }
                return dropdownArrow;
            }
        }

        private static Sprite dropdownArrow;

        protected static Sprite InputFieldBackground()
        {
            Texture2D tex = new Texture2D(2, 2);
            string InputFieldBackground = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAAC30lEQVR4nO1XTWhaQRAe856aqCBeI0EqAUEoFCSHnIqFBj316sE/CBYCQsGEnnoMFEpqQAqFQE4JJBAvPRSTFBp6E70UAgWP1oveiyYaY+fbuLKKLWh8tId8MKw4u/N9OzvvvR3d7/eTivn5eZqbmxO/b29vxdjr9chkMtEkUNeo8a6urobm6Varla6vr0mOWNjtdknTNJolEFMCm4QQjDqIbDYbNZtN4VSIfWwv2Z6yPYFrUk6272zf2PY4bkU6QA5OQIcyNQN9pRm27UgksuDz+cjj8UycEY6jVavVQKVSCRwfH2/wX2/YsvCBCxvGqIMU6I8WPrdPwWAwFA6Hye12C2Kc4TQ1gPrCBgKBwEKhUHh/cXHxnF0vmKstOUUNKHi3trYWSiaTQp3FYiFd1wciJgEKDtm8ubkRZ51KpchsNofOz8/fsntTztOVwI95UTqRSJDD4RCLIOI+GZAisFMmp1gsRmdnZ6/Yt89TfggB8lFjrPPONafTKQoEAlTyaQRIESBHJhErHo9rBwcH6zILurImtLq6Sna7/e7x6C+YFlI0YqibAAcLCA0EKDt7hGoXlXlP8lEgFmIi9uLiIjLjlj41AxakftbkoyJcLhcy4RwnwDByVcTo+2RIwKSFNq2IvwowUsS4+Dr9YzwIeBDwIOC/EtDudDoWXEKMRKvVwvBrnICfjUZj2ev1GiqgXq8LrnECTovFYtpoAaVSCZ/jLwMByrt5b2dnZ4NvwppRX8R2u027u7tdjr8/EIBrUx+XLOZjNptNb21tGSIgl8th+MDXtMuBgJFWafPo6GiZizEUjUZpaWlpJsS1Wo0ODw8pn8+f8gX1teobbc3anJHwyclJhm07k8ksrKysiLv9NOCmhMrlMnFWUfpDjYnk/FNrhomf+bzQmj2ju9ZsGqA1+8ox96BH/gnyQWsmO1bZMMomst/LbdKMoDanQ62ZrAE5yqv0rIHMyh5EbQd/A+JMPJandV0rAAAAAElFTkSuQmCC";
            tex.LoadImage(Convert.FromBase64String(InputFieldBackground));
            Sprite sp = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10, 10, 10, 10));
            sp.name = "InputFieldBackground";
            return sp;
        }

        protected static Sprite GetInputFieldBackground
        {
            get
            {
                if (inputFieldBackground == null)
                {
                    inputFieldBackground = InputFieldBackground();
                }
                return inputFieldBackground;
            }
        }

        private static Sprite inputFieldBackground;

        protected static Font ArialFont
        {
            get
            {
                if (_arialFont == null)
                {
                    _arialFont = Resources.FindObjectsOfTypeAll<Font>()[0];
                }
                return _arialFont;
            }
        }

        protected static Font _arialFont;

        protected static void AddLayerForEach(GameObject Base)
        {
            Transform[] transforms = Base.GetComponentsInChildren<Transform>(true);
            for (int i = 0; i < transforms.Length; i++)
            {
                transforms[i].gameObject.layer = 5;
            }
        }

        public static RawImage rawImage(GameObject Canvas, Vector2 position, string RawImageName = "RawImage")
        {
            RawImage rawimage = new GameObject(RawImageName, typeof(RawImage)).GetComponent<RawImage>();
            rawimage.transform.SetParent(Canvas.transform);
            rawimage.rectTransform.anchoredPosition = position;
            rawimage.gameObject.layer = 5;
            return rawimage;
        }

        public static Image image(GameObject Canvas, Vector2 position, string ImageName = "Image")
        {
            Image image = new GameObject(ImageName, typeof(Image)).GetComponent<Image>();
            image.transform.SetParent(Canvas.transform);
            image.rectTransform.anchoredPosition = position;
            image.gameObject.layer = 5;
            return image;
        }

        /// <summary>
        /// Make a single press button.
        /// </summary>
        public static Button LegacyButton(GameObject Canvas, Vector2 Position, string text, int fontSize = 14, string ButtonName = "Button (Legacy)")
        {
            Button button = new GameObject(ButtonName, typeof(Image), typeof(Button)).GetComponent<Button>();
            Text GUI_text = new GameObject("Text (Legacy)", typeof(Text)).GetComponent<Text>();
            button.transform.SetParent(Canvas.transform);
            button.image.rectTransform.sizeDelta = new Vector2(160, 30);
            button.image.sprite = GetUISprite;
            button.image.type = Image.Type.Sliced;
            GUI_text.transform.SetParent(button.transform);
            GUI_text.font = ArialFont;
            GUI_text.text = text;
            GUI_text.fontSize = fontSize;
            GUI_text.alignment = TextAnchor.MiddleCenter;
            GUI_text.color = new Color32(50, 50, 50, 255);
            GUI_text.rectTransform.anchorMin = Vector2.zero;
            GUI_text.rectTransform.anchorMax = Vector2.one;
            GUI_text.rectTransform.offsetMax = Vector2.zero;
            GUI_text.rectTransform.offsetMin = Vector2.zero;
            button.image.rectTransform.anchoredPosition = Position;
            AddLayerForEach(button.gameObject);
            return button;
        }

        /// <summary>
        /// Creates a Canvas.
        /// </summary>
        public static Canvas Canvas(string CanvasName = "Canvas")
        {
            Canvas Canvas = new GameObject(CanvasName, typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster)).GetComponent<Canvas>();
            Canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            Canvas.gameObject.layer = 5;
            return Canvas;
        }

        /// <summary>
        /// Make a Legacy UI text.
        /// </summary>
        public static Text LegacyText(GameObject Canvas, Vector2 position, string text, int fontSize = 14, string TextName = "Text (Legacy)")
        {
            Text TMPtext = new GameObject(TextName, typeof(Text)).GetComponent<Text>();
            TMPtext.rectTransform.sizeDelta = new Vector2(160, 30);
            TMPtext.transform.SetParent(Canvas.transform);
            TMPtext.text = text;
            TMPtext.fontSize = fontSize;
            TMPtext.font = ArialFont;
            TMPtext.color = new Color32(50, 50, 50, 255);
            TMPtext.gameObject.layer = 5;
            TMPtext.rectTransform.anchoredPosition = position;
            return TMPtext;
        }

        /// <summary>
        /// Creates a panel.
        /// </summary>
        public static Image Panel(GameObject Canvas, Vector2 Position, string PanelName = "Panel")
        {
            Image Panel = new GameObject(PanelName, typeof(Image)).GetComponent<Image>();
            Panel.transform.SetParent(Canvas.transform);
            Panel.sprite = GetBackground;
            Panel.type = Image.Type.Sliced;
            Panel.color = new Color32(255, 255, 255, 100);
            Panel.rectTransform.anchorMax = Vector2.one;
            Panel.rectTransform.anchorMin = Vector2.zero;
            Panel.rectTransform.sizeDelta = Vector2.zero;
            Panel.rectTransform.offsetMax = Vector2.zero;
            Panel.rectTransform.offsetMin = Vector2.zero;
            Panel.rectTransform.anchoredPosition = Position;
            Panel.gameObject.layer = 5;
            return Panel;
        }

        /// <summary>
        /// Creates a slider.
        /// </summary>
        public static Slider Slider(GameObject Canvas, Vector2 position, string SliderName = "Slider")
        {
            Slider Slider = new GameObject(SliderName, typeof(Slider)).GetComponent<Slider>();
            Image Background = new GameObject("Background", typeof(Image)).GetComponent<Image>();
            RectTransform Fill_Area = new GameObject("Fill Area", typeof(RectTransform)).GetComponent<RectTransform>();
            Image Fill = new GameObject("Fill", typeof(Image)).GetComponent<Image>();
            RectTransform Handle_Slide_Area = new GameObject("Handle Slide Area", typeof(RectTransform)).GetComponent<RectTransform>();
            Image Handle = new GameObject("Handle", typeof(Image)).GetComponent<Image>();
            Slider.transform.SetParent(Canvas.transform);
            Slider.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 20);
            Background.transform.SetParent(Slider.transform);
            Background.sprite = GetBackground;
            Background.type = Image.Type.Sliced;
            Background.rectTransform.anchorMin = new Vector2(0f, 0.25f);
            Background.rectTransform.anchorMax = new Vector2(1f, 0.75f);
            Background.rectTransform.sizeDelta = Vector2.zero;
            Fill_Area.transform.SetParent(Slider.transform);
            Fill_Area.anchorMin = new Vector2(0f, 0.25f);
            Fill_Area.anchorMax = new Vector2(1f, 0.75f);
            Fill_Area.sizeDelta = new Vector2(-20f, 0);
            Fill_Area.position = new Vector3(-5, 0, 0);
            Fill.type = Image.Type.Sliced;
            Fill.sprite = GetUISprite;
            Slider.fillRect = Fill.rectTransform;
            Fill.transform.SetParent(Fill_Area.transform);
            Fill.rectTransform.position = new Vector3(-5, 0, 0);
            Fill.rectTransform.sizeDelta = new Vector2(10, 0);
            Handle_Slide_Area.transform.SetParent(Slider.transform);
            Handle_Slide_Area.anchorMin = new Vector2(0f, 0f);
            Handle_Slide_Area.anchorMax = new Vector2(1f, 1f);
            Handle_Slide_Area.sizeDelta = new Vector2(-20, 0);
            Handle_Slide_Area.position = new Vector3(0, 0, 0);
            Handle.transform.SetParent(Handle_Slide_Area.transform);
            Handle.sprite = GetKnob;
            Handle.rectTransform.localPosition = new Vector3(0, 0, 0);
            Handle.rectTransform.sizeDelta = new Vector2(20, 0);
            Slider.handleRect = Handle.rectTransform;
            Slider.targetGraphic = Handle;
            Slider.GetComponent<RectTransform>().anchoredPosition = position;
            AddLayerForEach(Slider.gameObject);
            return Slider;
        }



        /// <summary>
        /// Creates a Toggler.
        /// </summary>
        public static Toggle Toggler(GameObject Canvas, Vector2 position, string Text, string ToggleName = "Toggle")
        {
            Toggle Toggle = new GameObject(ToggleName, typeof(Toggle)).GetComponent<Toggle>();
            Image Background = new GameObject("Background", typeof(Image)).GetComponent<Image>();
            Image Checkmark = new GameObject("Checkmark", typeof(Image)).GetComponent<Image>();
            Text Label = new GameObject("Label", typeof(Text)).GetComponent<Text>();
            Toggle.transform.SetParent(Canvas.transform);
            Background.transform.SetParent(Toggle.transform);
            Checkmark.transform.SetParent(Background.transform);
            Label.transform.SetParent(Toggle.transform);
            Toggle.isOn = true;
            Toggle.targetGraphic = Background;
            Toggle.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 20);
            RectTransform BackgroundRect = Background.rectTransform;
            BackgroundRect.anchoredPosition = new Vector3(10, -10);
            BackgroundRect.sizeDelta = new Vector2(20, 20);
            BackgroundRect.anchorMin = Vector2.up;
            BackgroundRect.anchorMax = Vector2.up;
            Background.type = Image.Type.Sliced;
            Background.sprite = GetUISprite;
            Label.text = Text;
            Label.font = ArialFont;
            Label.color = new Color32(50, 50, 50, 255);
            Label.rectTransform.anchorMin = Vector2.zero;
            Label.rectTransform.anchorMax = Vector2.one;
            Label.rectTransform.anchoredPosition = new Vector2(9, -0.50f);
            Label.rectTransform.sizeDelta = new Vector2(-28, -3);
            Checkmark.sprite = GetCheckmark;
            Checkmark.rectTransform.offsetMin = new Vector2(-20, -20);
            Checkmark.rectTransform.offsetMax = Vector2.zero;
            Checkmark.rectTransform.anchoredPosition = Vector3.zero;
            Toggle.GetComponent<RectTransform>().anchoredPosition = position;
            Toggle.graphic = Checkmark;
            AddLayerForEach(Toggle.gameObject);
            return Toggle;
        }

        /// <summary>
        /// Creates a ScrollView.
        /// </summary>
        public static ScrollRect ScrollView(GameObject canvas, Vector2 position, string ScrollViewName = "Scroll View")
        {
            ScrollRect scrollView = new GameObject(ScrollViewName, typeof(Image), typeof(ScrollRect)).GetComponent<ScrollRect>();
            Image Viewport = new GameObject("Viewport", typeof(Image), typeof(Mask)).GetComponent<Image>();
            RectTransform Content = new GameObject("Content", typeof(RectTransform)).GetComponent<RectTransform>();
            Scrollbar ScrollbarH = new GameObject("Scrollbar Horizontal", typeof(Image), typeof(Scrollbar)).GetComponent<Scrollbar>();
            RectTransform slidingAreaH = new GameObject("Sliding Area", typeof(RectTransform)).GetComponent<RectTransform>();
            Image handleH = new GameObject("Handle", typeof(Image)).GetComponent<Image>();
            Scrollbar ScrollbarV = new GameObject("Scrollbar Vertical", typeof(Image), typeof(Scrollbar)).GetComponent<Scrollbar>();
            RectTransform slidingAreaV = new GameObject("Sliding Area", typeof(RectTransform)).GetComponent<RectTransform>();
            Image handleV = new GameObject("Handle", typeof(Image)).GetComponent<Image>();
            scrollView.transform.SetParent(canvas.transform);
            Image scrollViewImg = scrollView.GetComponent<Image>();
            scrollViewImg.type = Image.Type.Sliced;
            scrollViewImg.color = new Color32(255, 255, 255, 100);
            scrollViewImg.rectTransform.sizeDelta = new Vector2(200, 200);
            scrollViewImg.sprite = GetBackground;
            Viewport.rectTransform.pivot = Vector2.up;
            Viewport.transform.SetParent(scrollView.transform);
            Viewport.sprite = GetUIMask;
            Viewport.type = Image.Type.Sliced;
            Viewport.GetComponent<Mask>().showMaskGraphic = false;
            Content.sizeDelta = new Vector2(+100, +300);
            Content.anchorMin = Vector2.up;
            Content.anchorMax = Vector2.one;
            Content.pivot = Vector2.up;
            Content.transform.SetParent(Viewport.transform);
            ScrollbarH.image.sprite = scrollViewImg.sprite;
            ScrollbarH.transform.SetParent(scrollView.transform);
            ScrollbarH.image.rectTransform.pivot = Vector2.zero;
            ScrollbarH.image.rectTransform.anchorMin = Vector2.zero;
            ScrollbarH.image.rectTransform.anchorMax = Vector2.zero;
            ScrollbarH.image.rectTransform.sizeDelta = new Vector2(0, 20);
            ScrollbarH.image.rectTransform.anchoredPosition = Vector2.zero;
            ScrollbarH.image.type = Image.Type.Sliced;
            slidingAreaH.transform.SetParent(ScrollbarH.transform);
            slidingAreaH.anchorMin = Vector2.zero;
            slidingAreaH.anchorMax = Vector2.one;
            slidingAreaH.sizeDelta = new Vector2(-20, -20);
            slidingAreaH.anchoredPosition = Vector2.zero;
            handleH.type = Image.Type.Sliced;
            handleH.sprite = GetUISprite;
            handleH.transform.SetParent(slidingAreaH.transform);
            handleH.rectTransform.sizeDelta = new Vector2(20, 20);
            handleH.rectTransform.anchoredPosition = Vector2.zero;
            ScrollbarV.transform.SetParent(scrollView.transform);
            ScrollbarV.image.rectTransform.sizeDelta = new Vector2(20, 0);
            ScrollbarV.image.rectTransform.anchorMin = Vector2.right;
            ScrollbarV.image.rectTransform.anchorMax = Vector2.right;
            ScrollbarV.image.rectTransform.pivot = Vector2.one;
            slidingAreaV.transform.SetParent(ScrollbarV.transform);
            slidingAreaV.sizeDelta = new Vector2(-20, -20);
            slidingAreaV.anchoredPosition = Vector2.zero;
            slidingAreaV.anchorMin = Vector2.zero;
            slidingAreaV.anchorMax = Vector2.one;
            handleV.type = Image.Type.Sliced;
            handleV.sprite = GetUISprite;
            handleV.transform.SetParent(slidingAreaV.transform);
            handleV.rectTransform.anchoredPosition = Vector2.zero;
            handleV.rectTransform.sizeDelta = new Vector2(20, 20);
            scrollView.content = Content;
            scrollView.viewport = Viewport.rectTransform;
            scrollView.horizontalScrollbar = ScrollbarH;
            scrollView.verticalScrollbar = ScrollbarV;
            scrollView.horizontalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
            scrollView.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
            scrollView.horizontalScrollbarSpacing = -3;
            scrollView.verticalScrollbarSpacing = -3;
            ScrollbarH.handleRect = handleH.rectTransform;
            ScrollbarH.targetGraphic = handleH;
            ScrollbarV.handleRect = handleV.rectTransform;
            ScrollbarV.image.sprite = scrollViewImg.sprite;
            ScrollbarV.image.type = Image.Type.Sliced;
            ScrollbarV.targetGraphic = handleV;
            ScrollbarV.direction = Scrollbar.Direction.BottomToTop;
            scrollViewImg.rectTransform.anchoredPosition = position;
            AddLayerForEach(scrollView.gameObject);
            return scrollView;
        }

        /// <summary>
        /// Creates a scrollbar.
        /// </summary>
        public static Scrollbar scrollbar(GameObject Canvas, Vector2 position, string ScrollbarName = "Scrollbar")
        {
            Scrollbar scrollbar = new GameObject(ScrollbarName, typeof(Image), typeof(Scrollbar)).GetComponent<Scrollbar>();
            RectTransform slidingArea = new GameObject("Sliding Area", typeof(RectTransform)).GetComponent<RectTransform>();
            Image handle = new GameObject("Handle", typeof(Image)).GetComponent<Image>();
            scrollbar.transform.SetParent(Canvas.transform);
            scrollbar.image.type = Image.Type.Sliced;
            scrollbar.image.rectTransform.sizeDelta = new Vector2(160, 20);
            scrollbar.image.rectTransform.anchoredPosition = position;
            scrollbar.image.sprite = GetBackground;
            slidingArea.transform.SetParent(scrollbar.transform, true);
            slidingArea.anchorMin = Vector2.zero;
            slidingArea.anchorMax = Vector2.one;
            slidingArea.sizeDelta = new Vector2(-20, -20);
            slidingArea.anchoredPosition = Vector2.zero;
            handle.type = Image.Type.Sliced;
            handle.sprite = GetUISprite;
            handle.transform.SetParent(slidingArea.transform);
            handle.rectTransform.sizeDelta = new Vector2(20, 20);
            handle.rectTransform.anchoredPosition = Vector2.zero;
            scrollbar.handleRect = handle.rectTransform;
            scrollbar.targetGraphic = handle;
            AddLayerForEach(scrollbar.gameObject);
            return scrollbar;
        }

        /// <summary>
        /// Creates a legacy InputField.
        /// </summary>
        public static InputField LegacyInputField(GameObject Canvas, Vector2 position, string InputFieldtext = "", string InputFieldName = "InputField (Legacy)")
        {
            InputField InputField = new GameObject(InputFieldName, typeof(Image), typeof(InputField)).GetComponent<InputField>();
            Text Placeholder = new GameObject("Placeholder", typeof(Text)).GetComponent<Text>();
            Text text = new GameObject("Text (Legacy)", typeof(Text)).GetComponent<Text>();
            InputField.transform.SetParent(Canvas.transform);
            InputField.image.type = Image.Type.Sliced;
            InputField.image.sprite = GetInputFieldBackground;
            InputField.image.rectTransform.sizeDelta = new Vector2(160, 30);
            Placeholder.transform.SetParent(InputField.transform);
            Placeholder.rectTransform.anchorMax = Vector2.one;
            Placeholder.rectTransform.anchorMin = Vector2.zero;
            Placeholder.rectTransform.offsetMax = Vector2.zero;
            Placeholder.rectTransform.offsetMin = Vector2.zero;
            Placeholder.rectTransform.anchoredPosition = new Vector2(0, -0.50f);
            Placeholder.rectTransform.sizeDelta = new Vector2(-20, -13);
            Placeholder.text = "Enter text...";
            Placeholder.font = ArialFont;
            Placeholder.fontStyle = FontStyle.Italic;
            Placeholder.color = new Color32(50, 50, 50, 128);
            text.transform.SetParent(InputField.transform);
            text.rectTransform.anchorMax = Vector2.one;
            text.rectTransform.anchorMin = Vector2.zero;
            text.rectTransform.offsetMax = Vector2.zero;
            text.rectTransform.offsetMin = Vector2.zero;
            text.rectTransform.sizeDelta = new Vector2(-20, -13);
            text.rectTransform.anchoredPosition = new Vector2(0, -0.50f);
            text.fontSize = 14;
            text.color = new Color32(50, 50, 50, 255);
            text.supportRichText = false;
            text.font = ArialFont;
            InputField.textComponent = text;
            InputField.placeholder = Placeholder;
            InputField.image.rectTransform.anchoredPosition = position;
            InputField.text = InputFieldtext;
            AddLayerForEach(InputField.gameObject);
            return InputField;
        }

        /// <summary>
        /// Creates a legacy DropDown.
        /// </summary>
        public static Dropdown LegacyDropDown(GameObject Canvas, Vector2 position, string DropDownName = "Dropdown (Legacy)")
        {
            Dropdown Dropdown = new GameObject(DropDownName, typeof(Image), typeof(Dropdown)).GetComponent<Dropdown>();
            Text Label = new GameObject("Label", typeof(Text)).GetComponent<Text>();
            Image Arrow = new GameObject("Arrow", typeof(Image)).GetComponent<Image>();
            Image Template = new GameObject("Template", typeof(Image), typeof(ScrollRect)).GetComponent<Image>();
            Image Viewport = new GameObject("Viewport", typeof(Image), typeof(Mask)).GetComponent<Image>();
            RectTransform Content = new GameObject("Content", typeof(RectTransform)).GetComponent<RectTransform>();
            Toggle Item = new GameObject("Item", typeof(Toggle)).GetComponent<Toggle>();
            Image ItemBackground = new GameObject("Item Background", typeof(Image)).GetComponent<Image>();
            Image ItemCheckmark = new GameObject("Item Checkmark", typeof(Image)).GetComponent<Image>();
            Text ItemLabel = new GameObject("Item Label", typeof(Text)).GetComponent<Text>();
            Scrollbar scrollbar = new GameObject("Scrollbar", typeof(Image), typeof(Scrollbar)).GetComponent<Scrollbar>();
            RectTransform slidingArea = new GameObject("Sliding Area", typeof(RectTransform)).GetComponent<RectTransform>();
            Image Handle = new GameObject("Handle", typeof(Image)).GetComponent<Image>();
            Dropdown.transform.SetParent(Canvas.transform);
            Dropdown.targetGraphic = Dropdown.GetComponent<Image>();
            Dropdown.image.rectTransform.sizeDelta = new Vector2(160, 30);
            Dropdown.image.rectTransform.sizeDelta = new Vector2(160, 30);
            Dropdown.image.sprite = GetUISprite;
            Dropdown.image.type = Image.Type.Sliced;
            Dropdown.AddOptions(new List<string> { "Option A", "Option B", "Option C" });
            Label.transform.SetParent(Dropdown.transform);
            Label.font = ArialFont;
            Label.color = new Color32(50, 50, 50, 255);
            Label.alignment = TextAnchor.MiddleLeft;
            Label.rectTransform.anchorMax = Vector2.one;
            Label.rectTransform.anchorMin = Vector2.zero;
            Label.rectTransform.sizeDelta = new Vector2(-35, -13);
            Label.rectTransform.anchoredPosition = new Vector2(-7.50f, -0.50f);
            Arrow.transform.SetParent(Dropdown.transform);
            Arrow.rectTransform.anchorMax = new Vector2(1, 0.5f);
            Arrow.rectTransform.anchorMin = new Vector2(1, 0.5f);
            Arrow.rectTransform.sizeDelta = new Vector2(20, 20);
            Arrow.rectTransform.anchoredPosition = new Vector2(-15, 0);
            Arrow.sprite = GetDropdownArrow;
            Template.rectTransform.sizeDelta = new Vector2(0, 150);
            Template.rectTransform.anchoredPosition = new Vector2(0, 2);
            Template.transform.SetParent(Dropdown.transform);
            Template.gameObject.SetActive(false);
            Template.sprite = Dropdown.image.sprite;
            Template.type = Image.Type.Sliced;
            Template.rectTransform.anchorMax = Vector2.right;
            Template.rectTransform.anchorMin = Vector2.zero;
            Template.rectTransform.pivot = new Vector2(0.5f, 1);
            Template.rectTransform.sizeDelta = new Vector2(0, 150);
            Template.rectTransform.anchoredPosition = new Vector2(0, 2);
            ScrollRect TPTMP = Template.GetComponent<ScrollRect>();
            TPTMP.movementType = ScrollRect.MovementType.Clamped;
            TPTMP.horizontal = false;
            TPTMP.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
            TPTMP.verticalScrollbarSpacing = -3;
            Viewport.rectTransform.sizeDelta = new Vector2(-18, -0);
            Viewport.rectTransform.anchoredPosition = Vector2.zero;
            Viewport.transform.SetParent(Template.transform);
            Viewport.sprite = GetUIMask;
            Viewport.type = Image.Type.Sliced;
            Viewport.GetComponent<Mask>().showMaskGraphic = false;
            Viewport.rectTransform.pivot = Vector2.up;
            Viewport.rectTransform.anchorMax = Vector2.one;
            Viewport.rectTransform.anchorMin = Vector2.zero;
            Viewport.rectTransform.sizeDelta = new Vector2(-18, 0);
            Viewport.rectTransform.anchoredPosition = Vector2.zero;
            scrollbar.transform.SetParent(Template.transform);
            scrollbar.image.sprite = GetBackground;
            scrollbar.image.type = Image.Type.Sliced;
            scrollbar.image.rectTransform.pivot = Vector2.one;
            scrollbar.image.rectTransform.anchorMax = Vector2.one;
            scrollbar.image.rectTransform.anchorMin = Vector2.right;
            scrollbar.image.rectTransform.sizeDelta = new Vector2(20, 0);
            scrollbar.image.rectTransform.anchoredPosition = Vector2.zero;
            slidingArea.transform.SetParent(scrollbar.transform);
            slidingArea.anchorMax = Vector2.one;
            slidingArea.anchorMin = Vector2.zero;
            slidingArea.sizeDelta = new Vector2(-20, -20);
            slidingArea.anchoredPosition = Vector2.zero;
            Handle.transform.SetParent(slidingArea.transform);
            Handle.sprite = GetUISprite;
            Handle.type = Image.Type.Sliced;
            Handle.rectTransform.sizeDelta = new Vector2(20, 20);
            Handle.rectTransform.anchoredPosition = Vector2.zero;
            scrollbar.targetGraphic = Handle;
            scrollbar.handleRect = Handle.rectTransform;
            scrollbar.direction = Scrollbar.Direction.BottomToTop;
            Content.transform.SetParent(Viewport.transform);
            Content.pivot = new Vector2(0.5f, 1);
            Content.anchorMax = Vector2.one;
            Content.anchorMin = Vector2.up;
            Content.sizeDelta = new Vector2(0, 28);
            Content.anchoredPosition = Vector2.zero;
            Item.isOn = true;
            Item.transform.SetParent(Content.transform);
            RectTransform ItemRect = Item.GetComponent<RectTransform>();
            ItemRect.anchorMax = new Vector2(1, 0.5f);
            ItemRect.anchorMin = new Vector2(0, 0.5f);
            ItemRect.sizeDelta = new Vector2(0, 20);
            ItemRect.anchoredPosition = Vector2.zero;
            Item.targetGraphic = ItemBackground;
            ItemBackground.transform.SetParent(Item.transform);
            ItemBackground.rectTransform.anchorMax = Vector2.one;
            ItemBackground.rectTransform.anchorMin = Vector2.zero;
            ItemBackground.rectTransform.sizeDelta = Vector2.zero;
            ItemBackground.rectTransform.anchoredPosition = Vector2.zero;
            Item.graphic = ItemCheckmark;
            ItemCheckmark.transform.SetParent(Item.transform);
            ItemCheckmark.sprite = GetCheckmark;
            ItemCheckmark.rectTransform.anchorMax = new Vector2(0, 0.5f);
            ItemCheckmark.rectTransform.anchorMin = new Vector2(0, 0.5f);
            ItemCheckmark.rectTransform.sizeDelta = new Vector2(20, 20);
            ItemCheckmark.rectTransform.anchoredPosition = new Vector2(10, 0);
            ItemLabel.transform.SetParent(Item.transform);
            ItemLabel.alignment = TextAnchor.MiddleLeft;
            ItemLabel.font = ArialFont;
            ItemLabel.text = Dropdown.options[0].text;
            ItemLabel.color = new Color32(50, 50, 50, 255);
            ItemLabel.rectTransform.anchorMax = Vector2.one;
            ItemLabel.rectTransform.anchorMin = Vector2.zero;
            ItemLabel.rectTransform.sizeDelta = new Vector2(-30, -3);
            ItemLabel.rectTransform.anchoredPosition = new Vector2(5, -0.50f);
            Dropdown.template = Template.rectTransform;
            Dropdown.captionText = Label;
            Dropdown.itemText = ItemLabel;
            TPTMP.content = Content;
            TPTMP.viewport = Viewport.rectTransform;
            TPTMP.verticalScrollbar = scrollbar;
            Dropdown.image.rectTransform.anchoredPosition = position;
            AddLayerForEach(Dropdown.gameObject);
            return Dropdown;
        }
    }
}
